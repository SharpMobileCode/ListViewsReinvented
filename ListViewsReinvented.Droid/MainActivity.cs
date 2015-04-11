
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Content;

namespace ListViewsReinvented.Droid
{
    [Activity(Label = "ListViews Reinvented", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView _recyclerView;
        private RecyclerView.LayoutManager _layoutManager;
        private CrewMemberRecyclerViewAdapter _adapter;

        private ProgressDialog _progressDialog;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            _progressDialog = new ProgressDialog(this);
            _progressDialog.SetProgressStyle(ProgressDialogStyle.Spinner);
            _progressDialog.SetMessage("Loading crew manifest . . .");
            _progressDialog.Show();

            //If the device is portrait, then show the RecyclerView in a vertical list,
            //else show it in horizontal list.
            _layoutManager = Resources.Configuration.Orientation == Android.Content.Res.Orientation.Portrait 
                ? new LinearLayoutManager(this, LinearLayoutManager.Vertical, false) 
                : new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false);

            //Experiement with a GridLayoutManger! You can create some cool looking UI!
            //This create a gridview with 2 rows that scrolls horizontally.
//            _layoutManager = new GridLayoutManager(this, 2, GridLayoutManager.Horizontal, false);

            //Create a reference to our RecyclerView and set the layout manager;
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.mainActivity_recyclerView);
            _recyclerView.SetLayoutManager(_layoutManager);

            //Get our crew member data. This could be a web service.
            SharedData.CrewManifest = await CrewManifest.GetAllCrewAsync();

            //Create the adapter for the RecyclerView with our crew data, and set
            //the adapter. Also, wire an event handler for when the user taps on each
            //individual item.
            _adapter = new CrewMemberRecyclerViewAdapter(SharedData.CrewManifest, this.Resources);
            _adapter.ItemClick += OnItemClick;
            _recyclerView.SetAdapter(_adapter);

            _progressDialog.Dismiss();
        }

        private void OnItemClick (object sender, int position)
        {
            var crewProfileIntent = new Intent(this, typeof(CrewMemberProfileActivity));
            crewProfileIntent.PutExtra("index", position);
            crewProfileIntent.PutExtra("imageResourceId", SharedData.CrewManifest[position].PhotoResourceId);

            StartActivity(crewProfileIntent);
        }
    }

    internal static class SharedData
    {
        public static List<CrewMember> CrewManifest { get; set;}
    }
}


