package md51335a73305baa4a96f5b4d6e009e08eb;


public class CreateAccountView
	extends md59766a46f25d47e5f07a3ea11bb4701f4.BaseActivity_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MosesApp.Droid.Views.Login.CreateAccountView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CreateAccountView.class, __md_methods);
	}


	public CreateAccountView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CreateAccountView.class)
			mono.android.TypeManager.Activate ("MosesApp.Droid.Views.Login.CreateAccountView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
