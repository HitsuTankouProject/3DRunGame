using UnityEngine;

public class InPutAction
{
    private InPutDevice inPutDevice;
    public InPutAction(InPutDevice target)
    {
        inPutDevice = target;
        inPutDevice.Init();
    }





}
