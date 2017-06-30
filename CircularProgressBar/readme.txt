					  Circular Progress Bar
 Circular ProgressBar is a custom control for WinForm with animation

=====================================================================

USAGE
	Build your application, and then use the toolbox to add the control
  to your forms.

KNOWN ISSUE WITH VISUAL STUDIO TOOLBOX
  If you couldn't find this control in the  toolbox and you failed to
  add it from the NuGet package directly, try using the copies of the
  library in your project's `Debug` or `Release` directories. 

  The  problem  with the  toolbox is  that it is  part of  the Visual 
  Studio and not your  project, and as the  result, it can't  resolve
  some dependencies, although they are already part of your project. 

  In this  case,  Visual Studio Toolbox needs  'WinFormAnimation.dll' 
  library  next to the  'CircularProgressBar.dll'  library to let you 
  use it.  However, you can always write the code manually and bypass
  the use of toolbox altogether.