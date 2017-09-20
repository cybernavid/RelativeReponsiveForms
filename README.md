## Synopsis

A number of utility classes which can be used within Xamarin Forms XAML files to position elements relatively. This is what I came up with, with my knowledge of C# and Xamarin Forms.
You can see it in action by cloning the repo and run it in you Xamarin IDE.

## Code Example

ScreenUtil is where all the magic is happening. In XAML views you can use things like:
Height="{x:Static su:ScreenUtil.VERT5}"

![RelativeReponsiveForms in action on Android](https://github.com/cybernavid/RelativeReponsiveForms/blob/master/screenshots/android.png)
![RelativeReponsiveForms in action on iOS](https://github.com/cybernavid/RelativeReponsiveForms/blob/master/screenshots/ios.png)

## Motivation

Xamarin Forms does support positioning elements using percentage values. Therefor I came up with this couple of utility classes.

I would be glad to hear from others as how they think about this piece of code.

## Installation

Just include the needed classes (ScreenUtil, IDisplay, Display_Android, Display_iOS) in your projects and off you go.

## License

[UNLICENSE.txt](https://github.com/cybernavid/RelativeReponsiveForms/blob/master/UNLICENSE.txt)
