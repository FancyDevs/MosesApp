using System;
using Android.Content;
using Android.Util;
using Android.Views;

namespace MosesApp.Droid.Controls
{
	public class BottomToolbar : View
	{
		protected virtual int LayoutResId => Resource.Layout.BottomToolbar;

		Context context;

		public BottomToolbar(Context context) : base(context)
		{
			Init(context);
		}
		public BottomToolbar(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			Init(context);
		}

		public BottomToolbar(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
		{
			Init(context);
		}

		void Init(Context ctx)
		{
			context = ctx;
		}
	}
}
