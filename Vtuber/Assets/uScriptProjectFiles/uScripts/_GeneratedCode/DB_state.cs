//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class DB_state : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public System.Single DB_CountTime = (float) 0;
   public System.Single DB_CountTime_Hour = (float) 0;
   public System.Single DB_CountTime_Min = (float) 0;
   public System.Single DB_CountTime_sec = (float) 0;
   public UnityEngine.GameObject DB_obj_txt_hour = default(UnityEngine.GameObject);
   UnityEngine.GameObject DB_obj_txt_hour_previous = null;
   public UnityEngine.GameObject DB_obj_txt_min = default(UnityEngine.GameObject);
   UnityEngine.GameObject DB_obj_txt_min_previous = null;
   public UnityEngine.GameObject DB_obj_txt_sec = default(UnityEngine.GameObject);
   UnityEngine.GameObject DB_obj_txt_sec_previous = null;
   System.Single local_10_System_Single = (float) 0;
   System.Single local_111_System_Single = (float) 0;
   System.String local_12_System_String = "";
   System.String local_14_System_String = "";
   System.String local_29_System_String = "";
   System.Single local_39_System_Single = (float) 0;
   System.Single local_9_System_Single = (float) 0;
   System.Single local_byou_System_Single = (float) 0;
   System.Single local_fun_System_Single = (float) 0;
   System.Single local_ji_System_Single = (float) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_Stopwatch logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1 = new uScriptAct_Stopwatch( );
   System.Single logic_uScriptAct_Stopwatch_Seconds_1;
   bool logic_uScriptAct_Stopwatch_Started_1 = true;
   bool logic_uScriptAct_Stopwatch_Stopped_1 = true;
   bool logic_uScriptAct_Stopwatch_Reset_1 = true;
   bool logic_uScriptAct_Stopwatch_CheckedTime_1 = true;
   //pointer to script instanced logic node
   uScriptAct_DivideFloat logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_5 = new uScriptAct_DivideFloat( );
   System.Single logic_uScriptAct_DivideFloat_A_5 = (float) 0;
   System.Single logic_uScriptAct_DivideFloat_B_5 = (float) 60;
   System.Single logic_uScriptAct_DivideFloat_FloatResult_5;
   System.Int32 logic_uScriptAct_DivideFloat_IntResult_5;
   bool logic_uScriptAct_DivideFloat_Out_5 = true;
   //pointer to script instanced logic node
   uScriptAct_DivideFloat logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_7 = new uScriptAct_DivideFloat( );
   System.Single logic_uScriptAct_DivideFloat_A_7 = (float) 0;
   System.Single logic_uScriptAct_DivideFloat_B_7 = (float) 60;
   System.Single logic_uScriptAct_DivideFloat_FloatResult_7;
   System.Int32 logic_uScriptAct_DivideFloat_IntResult_7;
   bool logic_uScriptAct_DivideFloat_Out_7 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_11 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_11 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_11 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_11 = "00";
   System.String logic_uScriptAct_FloatToString_CustomCulture_11 = "";
   System.String logic_uScriptAct_FloatToString_Result_11;
   bool logic_uScriptAct_FloatToString_Out_11 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_13 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_13 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_13 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_13 = "00";
   System.String logic_uScriptAct_FloatToString_CustomCulture_13 = "";
   System.String logic_uScriptAct_FloatToString_Result_13;
   bool logic_uScriptAct_FloatToString_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_15 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_15 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_15 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_15 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_15 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_15;
   bool logic_uScriptAct_SetString_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_16 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_16 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_16 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_16 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_16 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_16;
   bool logic_uScriptAct_SetString_Out_16 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatFunctions logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21 = new uScriptAct_FloatFunctions( );
   System.Single logic_uScriptAct_FloatFunctions_input_21 = (float) 0;
   System.Single logic_uScriptAct_FloatFunctions_output_21;
   bool logic_uScriptAct_FloatFunctions_Out_21 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatFunctions logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22 = new uScriptAct_FloatFunctions( );
   System.Single logic_uScriptAct_FloatFunctions_input_22 = (float) 0;
   System.Single logic_uScriptAct_FloatFunctions_output_22;
   bool logic_uScriptAct_FloatFunctions_Out_22 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatFunctions logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24 = new uScriptAct_FloatFunctions( );
   System.Single logic_uScriptAct_FloatFunctions_input_24 = (float) 0;
   System.Single logic_uScriptAct_FloatFunctions_output_24;
   bool logic_uScriptAct_FloatFunctions_Out_24 = true;
   //pointer to script instanced logic node
   uScriptAct_FloatToString logic_uScriptAct_FloatToString_uScriptAct_FloatToString_25 = new uScriptAct_FloatToString( );
   System.Single logic_uScriptAct_FloatToString_Target_25 = (float) 0;
   uScriptAct_FloatToString.FormatType logic_uScriptAct_FloatToString_StandardFormat_25 = uScriptAct_FloatToString.FormatType.General;
   System.String logic_uScriptAct_FloatToString_CustomFormat_25 = "00";
   System.String logic_uScriptAct_FloatToString_CustomCulture_25 = "";
   System.String logic_uScriptAct_FloatToString_Result_25;
   bool logic_uScriptAct_FloatToString_Out_25 = true;
   //pointer to script instanced logic node
   uScriptAct_SetString logic_uScriptAct_SetString_uScriptAct_SetString_26 = new uScriptAct_SetString( );
   System.String logic_uScriptAct_SetString_Value_26 = "";
   System.Boolean logic_uScriptAct_SetString_ToUpperCase_26 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_ToLowerCase_26 = (bool) false;
   System.Boolean logic_uScriptAct_SetString_TrimWhitespace_26 = (bool) false;
   System.String logic_uScriptAct_SetString_Target_26;
   bool logic_uScriptAct_SetString_Out_26 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_30 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_30 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_30 = (float) 60;
   bool logic_uScriptCon_CompareFloat_GreaterThan_30 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_30 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_30 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_30 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_30 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_30 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_32 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_32 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_32;
   bool logic_uScriptAct_SetFloat_Out_32 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_33 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_33 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_33 = (float) -60;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_33;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_33;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_33 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_36 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_36 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_36 = (float) 60;
   bool logic_uScriptCon_CompareFloat_GreaterThan_36 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_36 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_36 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_36 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_36 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_36 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_37 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_37 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_37;
   bool logic_uScriptAct_SetFloat_Out_37 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_40 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_40 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_40 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_40;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_40;
   bool logic_uScriptAct_AddFloat_v2_Out_40 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareFloat logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_96 = new uScriptCon_CompareFloat( );
   System.Single logic_uScriptCon_CompareFloat_A_96 = (float) 0;
   System.Single logic_uScriptCon_CompareFloat_B_96 = (float) 12;
   bool logic_uScriptCon_CompareFloat_GreaterThan_96 = true;
   bool logic_uScriptCon_CompareFloat_GreaterThanOrEqualTo_96 = true;
   bool logic_uScriptCon_CompareFloat_EqualTo_96 = true;
   bool logic_uScriptCon_CompareFloat_NotEqualTo_96 = true;
   bool logic_uScriptCon_CompareFloat_LessThanOrEqualTo_96 = true;
   bool logic_uScriptCon_CompareFloat_LessThan_96 = true;
   //pointer to script instanced logic node
   uScriptAct_SetFloat logic_uScriptAct_SetFloat_uScriptAct_SetFloat_98 = new uScriptAct_SetFloat( );
   System.Single logic_uScriptAct_SetFloat_Value_98 = (float) 0;
   System.Single logic_uScriptAct_SetFloat_Target_98;
   bool logic_uScriptAct_SetFloat_Out_98 = true;
   //pointer to script instanced logic node
   uScriptAct_MultiplyFloat_v2 logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_106 = new uScriptAct_MultiplyFloat_v2( );
   System.Single logic_uScriptAct_MultiplyFloat_v2_A_106 = (float) 0;
   System.Single logic_uScriptAct_MultiplyFloat_v2_B_106 = (float) -12;
   System.Single logic_uScriptAct_MultiplyFloat_v2_FloatResult_106;
   System.Int32 logic_uScriptAct_MultiplyFloat_v2_IntResult_106;
   bool logic_uScriptAct_MultiplyFloat_v2_Out_106 = true;
   //pointer to script instanced logic node
   uScriptAct_AddFloat_v2 logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_109 = new uScriptAct_AddFloat_v2( );
   System.Single logic_uScriptAct_AddFloat_v2_A_109 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_B_109 = (float) 0;
   System.Single logic_uScriptAct_AddFloat_v2_FloatResult_109;
   System.Int32 logic_uScriptAct_AddFloat_v2_IntResult_109;
   bool logic_uScriptAct_AddFloat_v2_Out_109 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_4 = default(UnityEngine.GameObject);
   
   //property nodes
   System.String property_text_Detox_ScriptEditor_Parameter_text_17 = "";
   System.String property_text_Detox_ScriptEditor_Parameter_text_18 = "";
   System.String property_text_Detox_ScriptEditor_Parameter_text_27 = "";
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   System.String property_text_Detox_ScriptEditor_Parameter_text_17_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_min != null)
      {
         component = DB_obj_txt_min.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_17_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_min != null)
      {
         component = DB_obj_txt_min.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_17;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_18_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_hour != null)
      {
         component = DB_obj_txt_hour.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_18_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_hour != null)
      {
         component = DB_obj_txt_hour.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_18;
      }
   }
   
   System.String property_text_Detox_ScriptEditor_Parameter_text_27_Get_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_sec != null)
      {
         component = DB_obj_txt_sec.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         return component.text;
      }
      else
      {
         return "";
      }
   }
   
   void property_text_Detox_ScriptEditor_Parameter_text_27_Set_Refresh( )
   {
      UnityEngine.UI.Text component = null;
      if (DB_obj_txt_sec != null)
      {
         component = DB_obj_txt_sec.GetComponent<UnityEngine.UI.Text>();
      }
      if ( null != component )
      {
         component.text = property_text_Detox_ScriptEditor_Parameter_text_27;
      }
   }
   
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_min_previous != DB_obj_txt_min || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_min_previous = DB_obj_txt_min;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_hour_previous != DB_obj_txt_hour || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_hour_previous = DB_obj_txt_hour;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_sec_previous != DB_obj_txt_sec || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_sec_previous = DB_obj_txt_sec;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_min_previous != DB_obj_txt_min || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_min_previous = DB_obj_txt_min;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_hour_previous != DB_obj_txt_hour || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_hour_previous = DB_obj_txt_hour;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( DB_obj_txt_sec_previous != DB_obj_txt_sec || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         DB_obj_txt_sec_previous = DB_obj_txt_sec;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_4 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_4 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_4 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_4.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_4;
                  component.OnLateUpdate += Instance_OnLateUpdate_4;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_4;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_4 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_4.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_4;
               component.OnLateUpdate -= Instance_OnLateUpdate_4;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_4;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.SetParent(g);
      logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_5.SetParent(g);
      logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_7.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_11.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_13.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_15.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_16.SetParent(g);
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.SetParent(g);
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.SetParent(g);
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.SetParent(g);
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_25.SetParent(g);
      logic_uScriptAct_SetString_uScriptAct_SetString_26.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_30.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_32.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_33.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_36.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_37.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_40.SetParent(g);
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_96.SetParent(g);
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_98.SetParent(g);
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_106.SetParent(g);
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_109.SetParent(g);
   }
   public void Awake()
   {
      
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
      
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Update( );
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_OnUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_4( );
   }
   
   void Instance_OnLateUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_4( );
   }
   
   void Instance_OnFixedUpdate_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_4( );
   }
   
   void Relay_StartTimer_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.StartTimer(out logic_uScriptAct_Stopwatch_Seconds_1);
      DB_CountTime = logic_uScriptAct_Stopwatch_Seconds_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Started;
      
      if ( test_0 == true )
      {
         Relay_Floor_24();
      }
   }
   
   void Relay_Stop_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Stop(out logic_uScriptAct_Stopwatch_Seconds_1);
      DB_CountTime = logic_uScriptAct_Stopwatch_Seconds_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Started;
      
      if ( test_0 == true )
      {
         Relay_Floor_24();
      }
   }
   
   void Relay_ResetTimer_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.ResetTimer(out logic_uScriptAct_Stopwatch_Seconds_1);
      DB_CountTime = logic_uScriptAct_Stopwatch_Seconds_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Started;
      
      if ( test_0 == true )
      {
         Relay_Floor_24();
      }
   }
   
   void Relay_CheckTime_1()
   {
      {
         {
         }
      }
      logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.CheckTime(out logic_uScriptAct_Stopwatch_Seconds_1);
      DB_CountTime = logic_uScriptAct_Stopwatch_Seconds_1;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_Stopwatch_uScriptAct_Stopwatch_1.Started;
      
      if ( test_0 == true )
      {
         Relay_Floor_24();
      }
   }
   
   void Relay_OnUpdate_4()
   {
      Relay_StartTimer_1();
   }
   
   void Relay_OnLateUpdate_4()
   {
   }
   
   void Relay_OnFixedUpdate_4()
   {
   }
   
   void Relay_In_5()
   {
      {
         {
            logic_uScriptAct_DivideFloat_A_5 = DB_CountTime;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_5.In(logic_uScriptAct_DivideFloat_A_5, logic_uScriptAct_DivideFloat_B_5, out logic_uScriptAct_DivideFloat_FloatResult_5, out logic_uScriptAct_DivideFloat_IntResult_5);
      local_9_System_Single = logic_uScriptAct_DivideFloat_FloatResult_5;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_5.Out;
      
      if ( test_0 == true )
      {
         Relay_Floor_21();
      }
   }
   
   void Relay_In_7()
   {
      {
         {
            logic_uScriptAct_DivideFloat_A_7 = local_fun_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_7.In(logic_uScriptAct_DivideFloat_A_7, logic_uScriptAct_DivideFloat_B_7, out logic_uScriptAct_DivideFloat_FloatResult_7, out logic_uScriptAct_DivideFloat_IntResult_7);
      local_10_System_Single = logic_uScriptAct_DivideFloat_FloatResult_7;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_DivideFloat_uScriptAct_DivideFloat_7.Out;
      
      if ( test_0 == true )
      {
         Relay_Floor_22();
      }
   }
   
   void Relay_In_11()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_11 = DB_CountTime_Min;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_11.In(logic_uScriptAct_FloatToString_Target_11, logic_uScriptAct_FloatToString_StandardFormat_11, logic_uScriptAct_FloatToString_CustomFormat_11, logic_uScriptAct_FloatToString_CustomCulture_11, out logic_uScriptAct_FloatToString_Result_11);
      local_12_System_String = logic_uScriptAct_FloatToString_Result_11;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_11.Out;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_In_13()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_13 = DB_CountTime_Hour;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_13.In(logic_uScriptAct_FloatToString_Target_13, logic_uScriptAct_FloatToString_StandardFormat_13, logic_uScriptAct_FloatToString_CustomFormat_13, logic_uScriptAct_FloatToString_CustomCulture_13, out logic_uScriptAct_FloatToString_Result_13);
      local_14_System_String = logic_uScriptAct_FloatToString_Result_13;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_13.Out;
      
      if ( test_0 == true )
      {
         Relay_In_26();
      }
   }
   
   void Relay_In_15()
   {
      {
         {
            logic_uScriptAct_SetString_Value_15 = local_12_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_15.In(logic_uScriptAct_SetString_Value_15, logic_uScriptAct_SetString_ToUpperCase_15, logic_uScriptAct_SetString_ToLowerCase_15, logic_uScriptAct_SetString_TrimWhitespace_15, out logic_uScriptAct_SetString_Target_15);
      property_text_Detox_ScriptEditor_Parameter_text_17 = logic_uScriptAct_SetString_Target_15;
      property_text_Detox_ScriptEditor_Parameter_text_17_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_15.Out;
      
      if ( test_0 == true )
      {
         Relay_In_16();
      }
   }
   
   void Relay_In_16()
   {
      {
         {
            logic_uScriptAct_SetString_Value_16 = local_14_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_16.In(logic_uScriptAct_SetString_Value_16, logic_uScriptAct_SetString_ToUpperCase_16, logic_uScriptAct_SetString_ToLowerCase_16, logic_uScriptAct_SetString_TrimWhitespace_16, out logic_uScriptAct_SetString_Target_16);
      property_text_Detox_ScriptEditor_Parameter_text_18 = logic_uScriptAct_SetString_Target_16;
      property_text_Detox_ScriptEditor_Parameter_text_18_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_Abs_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Abs(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Ceiling_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Ceiling(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Floor_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Floor(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Round_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Round(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Sign_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Sign(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Sqrt_21()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_21 = local_9_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Sqrt(logic_uScriptAct_FloatFunctions_input_21, out logic_uScriptAct_FloatFunctions_output_21);
      local_fun_System_Single = logic_uScriptAct_FloatFunctions_output_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_33();
      }
   }
   
   void Relay_Abs_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Abs(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Ceiling_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Ceiling(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Floor_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Floor(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Round_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Round(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Sign_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Sign(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Sqrt_22()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_22 = local_10_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Sqrt(logic_uScriptAct_FloatFunctions_input_22, out logic_uScriptAct_FloatFunctions_output_22);
      local_ji_System_Single = logic_uScriptAct_FloatFunctions_output_22;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_22.Out;
      
      if ( test_0 == true )
      {
         Relay_In_96();
      }
   }
   
   void Relay_Abs_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Abs(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_Ceiling_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Ceiling(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_Floor_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Floor(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_Round_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Round(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_Sign_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Sign(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_Sqrt_24()
   {
      {
         {
            logic_uScriptAct_FloatFunctions_input_24 = DB_CountTime;
            
         }
         {
         }
      }
      logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Sqrt(logic_uScriptAct_FloatFunctions_input_24, out logic_uScriptAct_FloatFunctions_output_24);
      local_byou_System_Single = logic_uScriptAct_FloatFunctions_output_24;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatFunctions_uScriptAct_FloatFunctions_24.Out;
      
      if ( test_0 == true )
      {
         Relay_In_30();
      }
   }
   
   void Relay_In_25()
   {
      {
         {
            logic_uScriptAct_FloatToString_Target_25 = DB_CountTime_sec;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_FloatToString_uScriptAct_FloatToString_25.In(logic_uScriptAct_FloatToString_Target_25, logic_uScriptAct_FloatToString_StandardFormat_25, logic_uScriptAct_FloatToString_CustomFormat_25, logic_uScriptAct_FloatToString_CustomCulture_25, out logic_uScriptAct_FloatToString_Result_25);
      local_29_System_String = logic_uScriptAct_FloatToString_Result_25;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_FloatToString_uScriptAct_FloatToString_25.Out;
      
      if ( test_0 == true )
      {
         Relay_In_11();
      }
   }
   
   void Relay_In_26()
   {
      {
         {
            logic_uScriptAct_SetString_Value_26 = local_29_System_String;
            
         }
         {
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetString_uScriptAct_SetString_26.In(logic_uScriptAct_SetString_Value_26, logic_uScriptAct_SetString_ToUpperCase_26, logic_uScriptAct_SetString_ToLowerCase_26, logic_uScriptAct_SetString_TrimWhitespace_26, out logic_uScriptAct_SetString_Target_26);
      property_text_Detox_ScriptEditor_Parameter_text_27 = logic_uScriptAct_SetString_Target_26;
      property_text_Detox_ScriptEditor_Parameter_text_27_Set_Refresh( );
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetString_uScriptAct_SetString_26.Out;
      
      if ( test_0 == true )
      {
         Relay_In_15();
      }
   }
   
   void Relay_In_30()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_30 = local_byou_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_30.In(logic_uScriptCon_CompareFloat_A_30, logic_uScriptCon_CompareFloat_B_30);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_30.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_30.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_5();
      }
      if ( test_1 == true )
      {
         Relay_In_32();
      }
   }
   
   void Relay_In_32()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_32 = local_byou_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_32.In(logic_uScriptAct_SetFloat_Value_32, out logic_uScriptAct_SetFloat_Target_32);
      DB_CountTime_sec = logic_uScriptAct_SetFloat_Target_32;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_32.Out;
      
      if ( test_0 == true )
      {
         Relay_Floor_21();
      }
   }
   
   void Relay_In_33()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_33 = local_fun_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_33.In(logic_uScriptAct_MultiplyFloat_v2_A_33, logic_uScriptAct_MultiplyFloat_v2_B_33, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_33, out logic_uScriptAct_MultiplyFloat_v2_IntResult_33);
      local_39_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_33;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_33.Out;
      
      if ( test_0 == true )
      {
         Relay_In_40();
      }
   }
   
   void Relay_In_36()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_36 = local_fun_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_36.In(logic_uScriptCon_CompareFloat_A_36, logic_uScriptCon_CompareFloat_B_36);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_36.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_36.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_7();
      }
      if ( test_1 == true )
      {
         Relay_In_37();
      }
   }
   
   void Relay_In_37()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_37 = local_fun_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_37.In(logic_uScriptAct_SetFloat_Value_37, out logic_uScriptAct_SetFloat_Target_37);
      DB_CountTime_Min = logic_uScriptAct_SetFloat_Target_37;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_37.Out;
      
      if ( test_0 == true )
      {
         Relay_Floor_22();
      }
   }
   
   void Relay_In_40()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_40 = local_byou_System_Single;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_40 = local_39_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_40.In(logic_uScriptAct_AddFloat_v2_A_40, logic_uScriptAct_AddFloat_v2_B_40, out logic_uScriptAct_AddFloat_v2_FloatResult_40, out logic_uScriptAct_AddFloat_v2_IntResult_40);
      DB_CountTime_sec = logic_uScriptAct_AddFloat_v2_FloatResult_40;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_40.Out;
      
      if ( test_0 == true )
      {
         Relay_In_36();
      }
   }
   
   void Relay_In_96()
   {
      {
         {
            logic_uScriptCon_CompareFloat_A_96 = local_ji_System_Single;
            
         }
         {
         }
      }
      logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_96.In(logic_uScriptCon_CompareFloat_A_96, logic_uScriptCon_CompareFloat_B_96);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_96.GreaterThanOrEqualTo;
      bool test_1 = logic_uScriptCon_CompareFloat_uScriptCon_CompareFloat_96.LessThan;
      
      if ( test_0 == true )
      {
         Relay_In_106();
      }
      if ( test_1 == true )
      {
         Relay_In_98();
      }
   }
   
   void Relay_In_98()
   {
      {
         {
            logic_uScriptAct_SetFloat_Value_98 = local_ji_System_Single;
            
         }
         {
         }
      }
      logic_uScriptAct_SetFloat_uScriptAct_SetFloat_98.In(logic_uScriptAct_SetFloat_Value_98, out logic_uScriptAct_SetFloat_Target_98);
      DB_CountTime_Hour = logic_uScriptAct_SetFloat_Target_98;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetFloat_uScriptAct_SetFloat_98.Out;
      
      if ( test_0 == true )
      {
         Relay_In_25();
      }
   }
   
   void Relay_In_106()
   {
      {
         {
            logic_uScriptAct_MultiplyFloat_v2_A_106 = local_ji_System_Single;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_106.In(logic_uScriptAct_MultiplyFloat_v2_A_106, logic_uScriptAct_MultiplyFloat_v2_B_106, out logic_uScriptAct_MultiplyFloat_v2_FloatResult_106, out logic_uScriptAct_MultiplyFloat_v2_IntResult_106);
      local_111_System_Single = logic_uScriptAct_MultiplyFloat_v2_FloatResult_106;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_MultiplyFloat_v2_uScriptAct_MultiplyFloat_v2_106.Out;
      
      if ( test_0 == true )
      {
         Relay_In_109();
      }
   }
   
   void Relay_In_109()
   {
      {
         {
            logic_uScriptAct_AddFloat_v2_A_109 = local_fun_System_Single;
            
         }
         {
            logic_uScriptAct_AddFloat_v2_B_109 = local_111_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_109.In(logic_uScriptAct_AddFloat_v2_A_109, logic_uScriptAct_AddFloat_v2_B_109, out logic_uScriptAct_AddFloat_v2_FloatResult_109, out logic_uScriptAct_AddFloat_v2_IntResult_109);
      DB_CountTime_Min = logic_uScriptAct_AddFloat_v2_FloatResult_109;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_AddFloat_v2_uScriptAct_AddFloat_v2_109.Out;
      
      if ( test_0 == true )
      {
         Relay_In_25();
      }
   }
   
}
