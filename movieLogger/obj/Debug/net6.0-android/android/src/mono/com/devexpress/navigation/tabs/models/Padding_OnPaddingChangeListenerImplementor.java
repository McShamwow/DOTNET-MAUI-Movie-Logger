package mono.com.devexpress.navigation.tabs.models;


public class Padding_OnPaddingChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.navigation.tabs.models.Padding.OnPaddingChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPaddingChanged:()V:GetOnPaddingChangedHandler:Com.Devexpress.Navigation.Tabs.Models.Padding/IOnPaddingChangeListenerInvoker, DevExpress.Maui.Android.Navigation\n" +
			"";
		mono.android.Runtime.register ("Com.Devexpress.Navigation.Tabs.Models.Padding+IOnPaddingChangeListenerImplementor, DevExpress.Maui.Android.Navigation", Padding_OnPaddingChangeListenerImplementor.class, __md_methods);
	}


	public Padding_OnPaddingChangeListenerImplementor ()
	{
		super ();
		if (getClass () == Padding_OnPaddingChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Devexpress.Navigation.Tabs.Models.Padding+IOnPaddingChangeListenerImplementor, DevExpress.Maui.Android.Navigation", "", this, new java.lang.Object[] {  });
	}


	public void onPaddingChanged ()
	{
		n_onPaddingChanged ();
	}

	private native void n_onPaddingChanged ();

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
