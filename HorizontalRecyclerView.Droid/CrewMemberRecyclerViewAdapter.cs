using System;
using System.Collections.Generic;
using Android.Graphics;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Content.Res;

namespace ListViewsReinvented.Droid
{
    public class CrewMemberRecyclerViewAdapter : RecyclerView.Adapter
    {
        //Create an Event so that our our clients can act when a user clicks
        //on each individual item.
        public event EventHandler<int> ItemClick;

        private List<CrewMember> _crewMembers;
        private readonly ImageManager _imageManager;

        public CrewMemberRecyclerViewAdapter(List<CrewMember> crewMembers, Resources resources)
        {
            _crewMembers = crewMembers;
            _imageManager = new ImageManager(resources);
        }

        //Must override, just like regular Adapters
        public override int ItemCount
        {
            get
            {
                return _crewMembers.Count;
            }
        }

        //Must override, this inflates our Layout and instantiates and assigns
        //it to the ViewHolder.
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            //Inflate our CrewMemberItem Layout
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.CrewMemberItem, parent, false);

            //Create our ViewHolder to cache the layout view references and register
            //the OnClick event.
            var viewHolder = new CrewMemberItemViewHolder(itemView, OnClick);

            return viewHolder;
        }

        //Must override, this is the important one.  This method is used to
        //bind our current data to your view holder.  Think of this as the equivalent
        //of GetView for regular Adapters.
        public override async void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = holder as CrewMemberItemViewHolder;

            var currentCrewMember = _crewMembers[position];

            //Bind our data from our data source to our View References
            viewHolder.CrewMemberName.Text = currentCrewMember.Name;
            viewHolder.RankAndPosting.Text = String.Format("{0}\n{1}", currentCrewMember.Rank, currentCrewMember.Posting);

            var photoBitmap = await _imageManager.GetScaledDownBitmapFromResourceAsync(currentCrewMember.PhotoResourceId, 120, 120);
            viewHolder.CrewMemberPhoto.SetImageBitmap(photoBitmap);
        }

        //This will fire any event handlers that are registered with our ItemClick
        //event.
        private void OnClick(int position)
        {
            if(ItemClick != null)
            {
                ItemClick(this, position);
            }
        }

        //Since this example uses a lot of Bitmaps, we want to do some house cleaning
        //and make them available for garbage collecting as soon as possible.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if(_imageManager != null)
            {
                _imageManager.Dispose();
            }

        }
    }
}

