
using System;

using Android.App;
using Android.OS;
using Android.Widget;

namespace HorizontalRecyclerView.Droid
{
    [Activity(Label = "Profile")]			
    public class CrewMemberProfileActivity : Activity
    {
        private TextView _rank;
        private TextView _name;
        private TextView _position;
        private TextView _posting;
        private TextView _species;
        private TextView _biogaphy;
        private ImageView _photo;

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CrewMemberProfile);

            _rank = FindViewById<TextView>(Resource.Id.crewMemberRankTextView);
            _name = FindViewById<TextView>(Resource.Id.crewMemberNameTextView);
            _position = FindViewById<TextView>(Resource.Id.crewMemberPositionTextView);
            _posting = FindViewById<TextView>(Resource.Id.crewMemberPostingTextView);
            _species = FindViewById<TextView>(Resource.Id.crewMemberSpeciesTextView);
            _biogaphy = FindViewById<TextView>(Resource.Id.crewMemberBioTextView);
            _photo = FindViewById<ImageView>(Resource.Id.crewMemberImageView);

            var index = Intent.GetIntExtra("index", -1);
            if(index < 0)
            {
                return;
            }

            var imageResourceId = Intent.GetIntExtra("imageResourceId", -1);

            var crewMember = SharedData.CrewManifest[index];

            _rank.Text = crewMember.Rank;
            _name.Text = crewMember.Name;
            _position.Text = crewMember.Position;
            _posting.Text = crewMember.Posting;
            _species.Text = String.Format("Species: {0}", crewMember.Species);
            _biogaphy.Text = crewMember.Biography;

            var imageManager = new ImageManager(this.Resources);
            var bitmap = await imageManager.GetScaledDownBitmapFromResourceAsync(imageResourceId, 150, 150);

            _photo.SetImageBitmap(bitmap);
        }
    }
}

