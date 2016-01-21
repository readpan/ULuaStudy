using UnityEngine;
using System.Collections;
using LuaInterface;

public class DoTest : MonoBehaviour
{

    string demoStr = @"
    LuaTest.PrintTest();
";

    // Use this for initialization
    void Start()
    {
        LuaScriptMgr luaMgr = new LuaScriptMgr();
        luaMgr.Start();
        LuaState l = luaMgr.lua;
        l.DoString(demoStr);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
