using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interface : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();
        //TestInterface(myClass);

        //myClass.TestFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*private void TestInterface(IMyInterface myInterface) 
{ 
    //myInterface.TestFunction(); 
}*/
public interface IMyInterface
{
    void TestFunction()
    {
        Debug.Log("MyTestFunct");
    }
}
public class MyClass : IMyInterface
{

}
