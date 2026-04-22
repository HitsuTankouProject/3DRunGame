using UnityEngine;
using UnityEngine.InputSystem;

public class InPutDevice
{
    public Mouse mouse {  get; private set; }
    public Keyboard keyboard { get; private set; }  

    public void Init()
    {
        mouse = Mouse.current;
        keyboard = Keyboard.current;
        if (mouse == null || keyboard == null)
            Debug.LogWarning("mouse==null or keyboard == null");
    }

}
