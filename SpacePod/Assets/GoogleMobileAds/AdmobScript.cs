using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdmobScript : MonoBehaviour
{
	InterstitialAd interstitial;

    // Use this for initialization
    void Start()
    {
        //Request Ads
        RequestBanner();
		RequestInterstitial();
    }

    public void showInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }

   private void RequestBanner()
	{
		#if UNITY_EDITOR
			string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-9706246874480287/1295192695";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-9706246874480287/6750823063";
		#else
			string adUnitId = "unexpected_platform";
		#endif

		// Create a 320x50 banner at the bottom of the screen.
		BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
	
	private void RequestInterstitial()
	{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-9706246874480287/1226554712";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-9706246874480287/3142750547";
		#else
			string adUnitId = "unexpected_platform";
		#endif

		// Initialize an InterstitialAd.
		interstitial = new InterstitialAd(adUnitId);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		interstitial.LoadAd(request);
	}

}