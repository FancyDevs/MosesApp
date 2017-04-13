using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MosesApp.Droid.Controls
{
	public class BottomToolbar : LinearLayout
	{
		public BottomToolbar(IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) { }
		public BottomToolbar(Context context, IAttributeSet attrs) : base (context, attrs) { Init(context, null); }
		public BottomToolbar(Context context, IAttributeSet attrs, int defStyleAttr) : base (context, attrs, defStyleAttr) { Init(context, attrs); }
		public BottomToolbar(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base (context, attrs, defStyleAttr, defStyleRes) { Init(context, attrs); }

		void Init(Context context, IAttributeSet attrs)
		{
			LayoutInflater.From(context).Inflate(Resource.Layout.BottomToolbar, this, true);
		}
	}
}
