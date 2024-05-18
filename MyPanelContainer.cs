using Godot;
using System;

public partial class MyPanelContainer : PanelContainer
{
  // Called when the node enters the scene tree for the first time.
  public override void _Ready()
  {
    // if you remove the theme override for panel in editor this still works but
    // ERROR: FATAL: Condition "!rc_owner" is true.
    // will be thrown on close and godot / editor won't close completely
    var styleBox = GetThemeStylebox("panel");
    if (styleBox is StyleBoxFlat flat)
    {
      flat.BorderColor = Colors.Aqua;
    }
  }

}
