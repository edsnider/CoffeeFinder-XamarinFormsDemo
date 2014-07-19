CoffeeFinder-XamarinFormsDemo
=============================

This is the demo app I built for my presentation at the [NoVA Mobile C# Dev Group on 7/9/14](http://forums.xamarin.com/discussion/19815/july-9-northern-va-dc-xamarin-3)

**Ed Snider** [@edsnider](http://www.twitter.com/edsnider) | [www.edsnider.net](http://www.edsnider.net) | [www.novamobiledev.org](http://www.novamobiledev.org)

###About this demo app
This was a simple demo showing how to use Xamarin and Xamarin.Forms to build native mobile apps with shared code for multiple platforms.  This demo includes an iOS, Android and Windows Phone 8.0 app and was built to demonstrate the following cross-platform mobile app dev concepts:

- Using [Xamarin w/ Visual Studio](http://xamarin.com/visual-studio)
- Using [Xamarin.Forms](http://developer.xamarin.com/guides/cross-platform/xamarin-forms) to share native UI
- Using the MVVM pattern
- Using System.Net.Http to get data from a REST endpoint - the [Foursquare Venues Search API](https://developer.foursquare.com/docs/venues/search) was used in this demo
- Using Portable Class Libraries (PCLs) to share code (both business logic and UI)

This is what the apps looked like at the end of the demo:

![](https://raw.githubusercontent.com/edsnider/CoffeeFinder-XamarinFormsDemo/master/Screenshots/coffeefinder-ios.png)
![](https://raw.githubusercontent.com/edsnider/CoffeeFinder-XamarinFormsDemo/master/Screenshots/coffeefinder-android.png)
![](https://raw.githubusercontent.com/edsnider/CoffeeFinder-XamarinFormsDemo/master/Screenshots/coffeefinder-wp8.png)

###Running the code
If you want to download or fork this code you'll need to get a Foursquare API Client ID and Client Secret and drop them into the `CoffeeFinder.Services.FoursquareService` class.  You can get this from [https://developer.foursquare.com/start](https://developer.foursquare.com/start). 

**Package dependencies**

You will also need the following NuGet packages:

for the CoffeeFinder (Portable) project:

- Xamarin.Forms
- Xamarin.Forms.Maps
- Json.NET
- Microsoft HTTP Client Libraries

for the CoffeeFinder.iOS project:

- Xamarin.Forms
- Xamarin.Forms.Maps

for the CoffeeFinder.Android project:

- Xamarin.Forms
- Xamarin.Forms.Maps (Also installs Xamarin Google Play Services Binding dependency) 

for the CoffeeFinder.WP8 project:

- Xamarin.Forms
- Xamarin.Forms.Maps
- Windows Phone Toolkit

###Questions
If you have any question please feel free to reach out to me.

-[@edsnider](http://www.twitter.com/edsnider)