//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class Play_anim : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject anim_prefab = default(UnityEngine.GameObject);
   UnityEngine.GameObject anim_prefab_previous = null;
   public System.Single Anim_Time = (float) 2;
   public UnityEngine.GameObject Close_Window = default(UnityEngine.GameObject);
   UnityEngine.GameObject Close_Window_previous = null;
   public UnityEngine.GameObject tmn_btn_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject tmn_btn_obj_previous = null;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_1 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_1 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_1 = (bool) false;
   System.Boolean logic_uScriptAct_Toggle_checkState_1 = (bool) true;
   bool logic_uScriptAct_Toggle_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_4 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_4 = (float) 0;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_4 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_4 = true;
   bool logic_uScriptAct_Delay_AfterDelay_4 = true;
   bool logic_uScriptAct_Delay_Stopped_4 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_4 = false;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_6 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_6 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_6 = (bool) false;
   System.Boolean logic_uScriptAct_Toggle_checkState_6 = (bool) true;
   bool logic_uScriptAct_Toggle_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_Toggle logic_uScriptAct_Toggle_uScriptAct_Toggle_7 = new uScriptAct_Toggle( );
   UnityEngine.GameObject[] logic_uScriptAct_Toggle_Target_7 = new UnityEngine.GameObject[] {};
   System.Boolean logic_uScriptAct_Toggle_IgnoreChildren_7 = (bool) false;
   System.Boolean logic_uScriptAct_Toggle_checkState_7 = (bool) false;
   bool logic_uScriptAct_Toggle_Out_7 = true;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( tmn_btn_obj_previous != tmn_btn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != tmn_btn_obj_previous )
         {
            {
               uScript_Button component = tmn_btn_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_2;
                  component.OnButtonDown -= Instance_OnButtonDown_2;
                  component.OnButtonUp -= Instance_OnButtonUp_2;
                  component.OnButtonEnter -= Instance_OnButtonEnter_2;
                  component.OnButtonExit -= Instance_OnButtonExit_2;
                  component.OnButtonDrag -= Instance_OnButtonDrag_2;
               }
            }
         }
         
         tmn_btn_obj_previous = tmn_btn_obj;
         
         //setup new listeners
         if ( null != tmn_btn_obj )
         {
            {
               uScript_Button component = tmn_btn_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = tmn_btn_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_2;
                  component.OnButtonDown += Instance_OnButtonDown_2;
                  component.OnButtonUp += Instance_OnButtonUp_2;
                  component.OnButtonEnter += Instance_OnButtonEnter_2;
                  component.OnButtonExit += Instance_OnButtonExit_2;
                  component.OnButtonDrag += Instance_OnButtonDrag_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         anim_prefab_previous = anim_prefab;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Close_Window_previous != Close_Window || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Close_Window_previous = Close_Window;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( tmn_btn_obj_previous != tmn_btn_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != tmn_btn_obj_previous )
         {
            {
               uScript_Button component = tmn_btn_obj_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_2;
                  component.OnButtonDown -= Instance_OnButtonDown_2;
                  component.OnButtonUp -= Instance_OnButtonUp_2;
                  component.OnButtonEnter -= Instance_OnButtonEnter_2;
                  component.OnButtonExit -= Instance_OnButtonExit_2;
                  component.OnButtonDrag -= Instance_OnButtonDrag_2;
               }
            }
         }
         
         tmn_btn_obj_previous = tmn_btn_obj;
         
         //setup new listeners
         if ( null != tmn_btn_obj )
         {
            {
               uScript_Button component = tmn_btn_obj.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = tmn_btn_obj.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_2;
                  component.OnButtonDown += Instance_OnButtonDown_2;
                  component.OnButtonUp += Instance_OnButtonUp_2;
                  component.OnButtonEnter += Instance_OnButtonEnter_2;
                  component.OnButtonExit += Instance_OnButtonExit_2;
                  component.OnButtonDrag += Instance_OnButtonDrag_2;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         anim_prefab_previous = anim_prefab;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Close_Window_previous != Close_Window || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Close_Window_previous = Close_Window;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != tmn_btn_obj )
      {
         {
            uScript_Button component = tmn_btn_obj.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_2;
               component.OnButtonDown -= Instance_OnButtonDown_2;
               component.OnButtonUp -= Instance_OnButtonUp_2;
               component.OnButtonEnter -= Instance_OnButtonEnter_2;
               component.OnButtonExit -= Instance_OnButtonExit_2;
               component.OnButtonDrag -= Instance_OnButtonDrag_2;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_4.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.SetParent(g);
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OnOut += uScriptAct_Toggle_OnOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OffOut += uScriptAct_Toggle_OffOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.ToggleOut += uScriptAct_Toggle_ToggleOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut += uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut += uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut += uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut += uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut += uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut += uScriptAct_Toggle_ToggleOut_7;
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
      
      if (true == logic_uScriptAct_Delay_DrivenDelay_4)
      {
         Relay_DrivenDelay_4();
      }
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OnOut -= uScriptAct_Toggle_OnOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.OffOut -= uScriptAct_Toggle_OffOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.ToggleOut -= uScriptAct_Toggle_ToggleOut_1;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OnOut -= uScriptAct_Toggle_OnOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.OffOut -= uScriptAct_Toggle_OffOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.ToggleOut -= uScriptAct_Toggle_ToggleOut_6;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OnOut -= uScriptAct_Toggle_OnOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.OffOut -= uScriptAct_Toggle_OffOut_7;
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.ToggleOut -= uScriptAct_Toggle_ToggleOut_7;
   }
   
   void Instance_OnButtonClick_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_2( );
   }
   
   void Instance_OnButtonDown_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_2( );
   }
   
   void Instance_OnButtonUp_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_2( );
   }
   
   void Instance_OnButtonEnter_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_2( );
   }
   
   void Instance_OnButtonExit_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_2( );
   }
   
   void Instance_OnButtonDrag_2(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_2( );
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
   
   void uScriptAct_Toggle_OnOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_6( );
   }
   
   void uScriptAct_Toggle_OffOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_6( );
   }
   
   void uScriptAct_Toggle_ToggleOut_6(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_6( );
   }
   
   void uScriptAct_Toggle_OnOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnOut_7( );
   }
   
   void uScriptAct_Toggle_OffOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OffOut_7( );
   }
   
   void uScriptAct_Toggle_ToggleOut_7(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_ToggleOut_7( );
   }
   
   void Relay_OnOut_1()
   {
      Relay_In_4();
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
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = anim_prefab;
            
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
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = anim_prefab;
            
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
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_1.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_1, index + 1);
            }
            logic_uScriptAct_Toggle_Target_1[ index++ ] = anim_prefab;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_1.Toggle(logic_uScriptAct_Toggle_Target_1, logic_uScriptAct_Toggle_IgnoreChildren_1, logic_uScriptAct_Toggle_checkState_1);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnButtonClick_2()
   {
   }
   
   void Relay_OnButtonDown_2()
   {
   }
   
   void Relay_OnButtonUp_2()
   {
      Relay_TurnOff_7();
      Relay_TurnOn_1();
   }
   
   void Relay_OnButtonEnter_2()
   {
   }
   
   void Relay_OnButtonExit_2()
   {
   }
   
   void Relay_OnButtonDrag_2()
   {
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_4 = Anim_Time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_4.In(logic_uScriptAct_Delay_Duration_4, logic_uScriptAct_Delay_SingleFrame_4);
      logic_uScriptAct_Delay_DrivenDelay_4 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_4.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_TurnOff_6();
      }
   }
   
   void Relay_Stop_4()
   {
      {
         {
            logic_uScriptAct_Delay_Duration_4 = Anim_Time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_uScriptAct_Delay_4.Stop(logic_uScriptAct_Delay_Duration_4, logic_uScriptAct_Delay_SingleFrame_4);
      logic_uScriptAct_Delay_DrivenDelay_4 = true;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_4.AfterDelay;
      
      if ( test_0 == true )
      {
         Relay_TurnOff_6();
      }
   }
   
   void Relay_DrivenDelay_4( )
   {
      {
         {
            logic_uScriptAct_Delay_Duration_4 = Anim_Time;
            
         }
         {
         }
      }
      logic_uScriptAct_Delay_DrivenDelay_4 = logic_uScriptAct_Delay_uScriptAct_Delay_4.DrivenDelay();
      if ( true == logic_uScriptAct_Delay_DrivenDelay_4 )
      {
         if ( logic_uScriptAct_Delay_uScriptAct_Delay_4.AfterDelay == true )
         {
            Relay_TurnOff_6();
         }
      }
   }
   void Relay_OnOut_6()
   {
   }
   
   void Relay_OffOut_6()
   {
   }
   
   void Relay_ToggleOut_6()
   {
   }
   
   void Relay_TurnOn_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
            }
            logic_uScriptAct_Toggle_Target_6[ index++ ] = anim_prefab;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOn(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6, logic_uScriptAct_Toggle_checkState_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_TurnOff_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
            }
            logic_uScriptAct_Toggle_Target_6[ index++ ] = anim_prefab;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.TurnOff(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6, logic_uScriptAct_Toggle_checkState_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_6()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( anim_prefab_previous != anim_prefab || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  anim_prefab_previous = anim_prefab;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_6.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_6, index + 1);
            }
            logic_uScriptAct_Toggle_Target_6[ index++ ] = anim_prefab;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_6.Toggle(logic_uScriptAct_Toggle_Target_6, logic_uScriptAct_Toggle_IgnoreChildren_6, logic_uScriptAct_Toggle_checkState_6);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_OnOut_7()
   {
   }
   
   void Relay_OffOut_7()
   {
   }
   
   void Relay_ToggleOut_7()
   {
   }
   
   void Relay_TurnOn_7()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Close_Window_previous != Close_Window || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Close_Window_previous = Close_Window;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
            }
            logic_uScriptAct_Toggle_Target_7[ index++ ] = Close_Window;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOn(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7, logic_uScriptAct_Toggle_checkState_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_TurnOff_7()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Close_Window_previous != Close_Window || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Close_Window_previous = Close_Window;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
            }
            logic_uScriptAct_Toggle_Target_7[ index++ ] = Close_Window;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.TurnOff(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7, logic_uScriptAct_Toggle_checkState_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Toggle_7()
   {
      {
         {
            int index = 0;
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Close_Window_previous != Close_Window || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Close_Window_previous = Close_Window;
                  
                  //setup new listeners
               }
            }
            if ( logic_uScriptAct_Toggle_Target_7.Length <= index)
            {
               System.Array.Resize(ref logic_uScriptAct_Toggle_Target_7, index + 1);
            }
            logic_uScriptAct_Toggle_Target_7[ index++ ] = Close_Window;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_Toggle_uScriptAct_Toggle_7.Toggle(logic_uScriptAct_Toggle_Target_7, logic_uScriptAct_Toggle_IgnoreChildren_7, logic_uScriptAct_Toggle_checkState_7);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
}
