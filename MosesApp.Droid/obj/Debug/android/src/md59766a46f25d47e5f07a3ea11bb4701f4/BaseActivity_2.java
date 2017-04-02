package md59766a46f25d47e5f07a3ea11bb4701f4;


public abstract class BaseActivity_2
	extends md59766a46f25d47e5f07a3ea11bb4701f4.BaseActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MosesApp.Droid.BaseActivity`2, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", BaseActivity_2.class, __md_methods);
	}


	public BaseActivity_2 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == BaseActivity_2.class)
			mono.android.TypeManager.Activate ("MosesApp.Droid.BaseActivity`2, MosesApp.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
