using UnityEngine;
using System.Collections;
using LuaInterface;

public class HelloWorld : MonoBehaviour
{

    // Use this for initialization
    IEnumerator Start()
    {
        LuaState l = new LuaState();
        string str = "print('hello world 世界')";
        WWW www = new WWW(@"http://readpan.top/UlaTest.txt");
        yield return www;
        print(www.text);
        l.DoString(www.text);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
