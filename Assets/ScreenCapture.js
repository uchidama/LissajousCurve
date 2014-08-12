#pragma strict

var folder = "ScreenshotFolder";
var frameRate = 25;

function Start () {

    // Set the playback framerate (real time will not relate to game time after this).
    Time.captureFramerate = frameRate;
 
    // Create the folder
    System.IO.Directory.CreateDirectory(folder);
    
}

function Update () {

    // Append filename to folder name (format is '0005 shot.png"')
    var name = String.Format("{0}/{1:D04} shot.png", folder, Time.frameCount );
 
    // Capture the screenshot to the specified file.
    Application.CaptureScreenshot(name);
}