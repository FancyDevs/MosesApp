package md508f189393849942af9754d104b79fee5;


public class RegisterView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MosesApp.Droid.Source.Views.RegisterView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegisterView.class, __md_methods);
	}


	public RegisterView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegisterView.class)
			mono.android.TypeManager.Activate ("MosesApp.Droid.Source.Views.RegisterView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
