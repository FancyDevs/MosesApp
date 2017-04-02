package md535c693ef49a1a85a26c166f3ff0ea0fc;


public class RegisterView
	extends md59766a46f25d47e5f07a3ea11bb4701f4.BaseActivity_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MosesApp.Droid.Source.Views.Register.RegisterView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RegisterView.class, __md_methods);
	}


	public RegisterView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RegisterView.class)
			mono.android.TypeManager.Activate ("MosesApp.Droid.Source.Views.Register.RegisterView, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
