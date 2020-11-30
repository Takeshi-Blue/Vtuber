//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class tmn_open : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject btn_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject btn_obj_previous = null;
   public UnityEngine.GameObject tmn_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject tmn_obj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_1 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_1 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_1 = (bool) false;
   System.Boolean logic_uScriptAct_Toggle_checkState_1 = (bool) true;
   bool logic_uScriptAct_Toggle_Out_1 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( tmn_obj_previous != tmn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         tmn_obj_previous = tmn_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( btn_obj_previous != btn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != btn_obj_previous )
         {
            {
               uScript_Button component = btn_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         btn_obj_previous = btn_obj;
         
         //setup new listeners
         if ( null != btn_obj )
         {
            {
               uScript_Button component = btn_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = btn_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( tmn_obj_previous != tmn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         tmn_obj_previous = tmn_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( btn_obj_previous != btn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != btn_obj_previous )
         {
            {
               uScript_Button component = btn_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_0;
                  component.OnButtonDown -= Instance_OnButtonDown_0;
                  component.OnButtonUp -= Instance_OnButtonUp_0;
                  component.OnButtonEnter -= Instance_OnButtonEnter_0;
                  component.OnButtonExit -= Instance_OnButtonExit_0;
                  component.OnButtonDrag -= Instance_OnButtonDrag_0;
               }
            }
         }
         
         btn_obj_previous = btn_obj;
         
         //setup new listeners
         if ( null != btn_obj )
         {
            {
               uScript_Button component = btn_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = btn_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_0;
                  component.OnButtonDown += Instance_OnButtonDown_0;
                  component.OnButtonUp += Instance_OnButtonUp_0;
                  component.OnButtonEnter += Instance_OnButtonEnter_0;
                  component.OnButtonExit += Instance_OnButtonExit_0;
                  component.OnButtonDrag += Instance_OnButtonDrag_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != btn_obj )
      {
         {
            uScript_Button component = btn_obj.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_0;
               component.OnButtonDown -= Instance_OnButtonDown_0;
               component.OnButtonUp -= Instance_OnButtonUp_0;
               component.OnButtonEnter -= Instance_OnButtonEnter_0;
               component.OnButtonExit -= Instance_OnButtonExit_0;
               component.OnButtonDrag -= Instance_OnButtonDrag_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OnOut += uScriptAct_Toggle_OnOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OffOut += uScriptAct_Toggle_OffOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.ToggleOut += uScriptAct_Toggle_ToggleOut_1;
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OnOut -= uScriptAct_Toggle_OnOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OffOut -= uScriptAct_Toggle_OffOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.ToggleOut -= uScriptAct_Toggle_ToggleOut_1;
   }
   
   void Instance_OnButtonClick_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_0( );
   }
   
   void Instance_OnButtonDown_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_0( );
   }
   
   void Instance_OnButtonUp_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_0( );
   }
   
   void Instance_OnButtonEnter_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_0( );
   }
   
   void Instance_OnButtonExit_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_0( );
   }
   
   void Instance_OnButtonDrag_0(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_0( );
   }
   
   void uScriptAct_Toggle_OnOut_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_1( );
   }
   
   void uScriptAct_Toggle_OffOut_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_1( );
   }
   
   void uScriptAct_Toggle_ToggleOut_1(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_1( );
   }
   
   void Relay_OnButtonClick_0()
   {
   }
   
   void Relay_OnButtonDown_0()
   {
   }
   
   void Relay_OnButtonUp_0()
   {
      Relay_Toggle_1();
   }
   
   void Relay_OnButtonEnter_0()
   {
   }
   
   void Relay_OnButtonExit_0()
   {
   }
   
   void Relay_OnButtonDrag_0()
   {
   }
   
   void Relay_OnOut_1()
   {
   }
   
   void Relay_OffOut_1()
   {
   }
   
   void Relay_ToggleOut_1()
   {
   }
   
   void Relay_TurnOn_1()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( tmn_obj_previous != tmn_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  tmn_obj_previous = tmn_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = tmn_obj;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.TurnOn(logic_uScriptAct_Toggle_Target_1, logic_uScriptAct_Toggle_IgnoreChildren_1, logic_uScriptAct_Toggle_checkState_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_TurnOff_1()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( tmn_obj_previous != tmn_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  tmn_obj_previous = tmn_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = tmn_obj;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.TurnOff(logic_uScriptAct_Toggle_Target_1, logic_uScriptAct_Toggle_IgnoreChildren_1, logic_uScriptAct_Toggle_checkState_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_1()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( tmn_obj_previous != tmn_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  tmn_obj_previous = tmn_obj;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = tmn_obj;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.Toggle(logic_uScriptAct_Toggle_Target_1, logic_uScriptAct_Toggle_IgnoreChildren_1, logic_uScriptAct_Toggle_checkState_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
