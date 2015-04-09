using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ListViewsReinvented.Droid
{
    //The ViewHolder Pattern is built into the RecyclerView,
    //So we must create a view holder as this will act as a cache
    //for our View references.
    public class CrewMemberItemViewHolder : RecyclerView.ViewHolder
    {
        public ImageView CrewMemberPhoto { get; set; }
        public TextView CrewMemberName { get; set; }
        public TextView RankAndPosting { get; set; }
        
        public CrewMemberItemViewHolder(View itemView, Action<int> listener) 
            : base (itemView)
        {
            //Creates and caches our views defined in our layout
            CrewMemberPhoto = itemView.FindViewById<ImageView>(Resource.Id.crewMemberItem_Photo);
            CrewMemberName = itemView.FindViewById<TextView>(Resource.Id.crewMemberItem_Name);
            RankAndPosting = itemView.FindViewById<TextView>(Resource.Id.crewMemberItem_RankPosting);

            // Detect user clicks on the item view and report which item
            // was clicked (by position) to the listener:
            itemView.Click += (sender, e) => listener (base.Position);
        }
    }
}

