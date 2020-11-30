//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class randomraycast_addobj : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   public UnityEngine.GameObject attach_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject attach_obj_previous = null;
   [Multiline(3)]
   public System.String attach_prefab_name = "";
   [Multiline(3)]
   public System.String attach_prefab_pass = "";
   public UnityEngine.Camera Cam_Raycast = default(UnityEngine.Camera);
   public UnityEngine.GameObject Head_Obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject Head_Obj_previous = null;
   public UnityEngine.Vector3 Hit_Normal = new Vector3( (float)0, (float)0, (float)0 );
   public UnityEngine.GameObject hit_obj = default(UnityEngine.GameObject);
   UnityEngine.GameObject hit_obj_previous = null;
   public UnityEngine.Vector3 Hit_Pos = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.Quaternion local_20_UnityEngine_Quaternion = new Quaternion( (float)0, (float)0, (float)0, (float)0 );
   System.Single local_22_System_Single = (float) 0;
   System.Single local_23_System_Single = (float) 0;
   System.Single local_24_System_Single = (float) 0;
   UnityEngine.Vector2 local_5_UnityEngine_Vector2 = new Vector2( (float)0, (float)0 );
   public UnityEngine.GameObject Ray_testbuttom = default(UnityEngine.GameObject);
   UnityEngine.GameObject Ray_testbuttom_previous = null;
   public System.Single Ray_X_Max = (float) 0;
   public System.Single Ray_X_Min = (float) 0;
   public System.Single Ray_Y_Max = (float) 1080;
   public System.Single Ray_Y_Min = (float) 1080;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_RaycastFromScreenPoint logic_uScriptAct_RaycastFromScreenPoint_uScriptAct_RaycastFromScreenPoint_3 = new uScriptAct_RaycastFromScreenPoint( );
   UnityEngine.Camera logic_uScriptAct_RaycastFromScreenPoint_Camera_3 = default(UnityEngine.Camera);
   UnityEngine.Vector2 logic_uScriptAct_RaycastFromScreenPoint_ScreenPosition_3 = new Vector2( );
   System.Single logic_uScriptAct_RaycastFromScreenPoint_Distance_3 = (float) 100;
   UnityEngine.LayerMask logic_uScriptAct_RaycastFromScreenPoint_layerMask_3 = 1;
   System.Boolean logic_uScriptAct_RaycastFromScreenPoint_include_3 = (bool) true;
   System.Boolean logic_uScriptAct_RaycastFromScreenPoint_showRay_3 = (bool) true;
   UnityEngine.GameObject logic_uScriptAct_RaycastFromScreenPoint_HitObject_3;
   System.Single logic_uScriptAct_RaycastFromScreenPoint_HitDistance_3;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromScreenPoint_HitLocation_3;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromScreenPoint_HitNormal_3;
   bool logic_uScriptAct_RaycastFromScreenPoint_NotObstructed_3 = true;
   bool logic_uScriptAct_RaycastFromScreenPoint_Obstructed_3 = true;
   //pointer to script instanced logic node
   uScriptAct_SetRandomVector2 logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4 = new uScriptAct_SetRandomVector2( );
   System.Single logic_uScriptAct_SetRandomVector2_MinX_4 = (float) 0;
   System.Single logic_uScriptAct_SetRandomVector2_MaxX_4 = (float) 0;
   System.Single logic_uScriptAct_SetRandomVector2_MinY_4 = (float) 0;
   System.Single logic_uScriptAct_SetRandomVector2_MaxY_4 = (float) 0;
   UnityEngine.Vector2 logic_uScriptAct_SetRandomVector2_TargetVector2_4;
   bool logic_uScriptAct_SetRandomVector2_Out_4 = true;
   //pointer to script instanced logic node
   uScriptCon_CompareGameObjects logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13 = new uScriptCon_CompareGameObjects( );
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_A_13 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptCon_CompareGameObjects_B_13 = default(UnityEngine.GameObject);
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByTag_13 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_CompareByName_13 = (bool) false;
   System.Boolean logic_uScriptCon_CompareGameObjects_ReportNull_13 = (bool) true;
   bool logic_uScriptCon_CompareGameObjects_Same_13 = true;
   bool logic_uScriptCon_CompareGameObjects_Different_13 = true;
   //pointer to script instanced logic node
   uScriptAct_LoadPrefab logic_uScriptAct_LoadPrefab_uScriptAct_LoadPrefab_15 = new uScriptAct_LoadPrefab( );
   System.String logic_uScriptAct_LoadPrefab_name_15 = "";
   UnityEngine.GameObject logic_uScriptAct_LoadPrefab_asset_15;
   bool logic_uScriptAct_LoadPrefab_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnChildPrefabAtLocation logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18 = new uScriptAct_SpawnChildPrefabAtLocation( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_18 = "";
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_18 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_18 = new Vector3( );
   UnityEngine.Quaternion logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_18 = new Quaternion( );
   System.String logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_18 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_18 = default(UnityEngine.GameObject);
   UnityEngine.GameObject logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18;
   System.Int32 logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_18;
   System.Boolean logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_18 = (bool) true;
   bool logic_uScriptAct_SpawnChildPrefabAtLocation_Immediate_18 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_19 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_19 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_19;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_19;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_19;
   bool logic_uScriptAct_GetComponentsVector3_Out_19 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsQuaternion logic_uScriptAct_SetComponentsQuaternion_uScriptAct_SetComponentsQuaternion_21 = new uScriptAct_SetComponentsQuaternion( );
   System.Single logic_uScriptAct_SetComponentsQuaternion_X_21 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsQuaternion_Y_21 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsQuaternion_Z_21 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsQuaternion_W_21 = (float) 0;
   UnityEngine.Quaternion logic_uScriptAct_SetComponentsQuaternion_OutputQuaternion_21;
   bool logic_uScriptAct_SetComponentsQuaternion_Out_21 = true;
   
   //event nodes
   UnityEngine.SceneManagement.Scene event_UnityEngine_GameObject_Scene_26 = default(UnityEngine.SceneManagement.Scene);
   UnityEngine.SceneManagement.LoadSceneMode event_UnityEngine_GameObject_LoadSceneMode_26 = UnityEngine.SceneManagement.LoadSceneMode.Single;
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_26 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( hit_obj_previous != hit_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         hit_obj_previous = hit_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Ray_testbuttom_previous != Ray_testbuttom || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Ray_testbuttom_previous )
         {
            {
               uScript_Button component = Ray_testbuttom_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_9;
                  component.OnButtonDown -= Instance_OnButtonDown_9;
                  component.OnButtonUp -= Instance_OnButtonUp_9;
                  component.OnButtonEnter -= Instance_OnButtonEnter_9;
                  component.OnButtonExit -= Instance_OnButtonExit_9;
                  component.OnButtonDrag -= Instance_OnButtonDrag_9;
               }
            }
         }
         
         Ray_testbuttom_previous = Ray_testbuttom;
         
         //setup new listeners
         if ( null != Ray_testbuttom )
         {
            {
               uScript_Button component = Ray_testbuttom.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Ray_testbuttom.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_9;
                  component.OnButtonDown += Instance_OnButtonDown_9;
                  component.OnButtonUp += Instance_OnButtonUp_9;
                  component.OnButtonEnter += Instance_OnButtonEnter_9;
                  component.OnButtonExit += Instance_OnButtonExit_9;
                  component.OnButtonDrag += Instance_OnButtonDrag_9;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Head_Obj_previous != Head_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Head_Obj_previous = Head_Obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( attach_obj_previous != attach_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         attach_obj_previous = attach_obj;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( hit_obj_previous != hit_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         hit_obj_previous = hit_obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Ray_testbuttom_previous != Ray_testbuttom || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != Ray_testbuttom_previous )
         {
            {
               uScript_Button component = Ray_testbuttom_previous.GetComponent<uScript_Button>();
               if ( null != component )
               {
                  component.OnButtonClick -= Instance_OnButtonClick_9;
                  component.OnButtonDown -= Instance_OnButtonDown_9;
                  component.OnButtonUp -= Instance_OnButtonUp_9;
                  component.OnButtonEnter -= Instance_OnButtonEnter_9;
                  component.OnButtonExit -= Instance_OnButtonExit_9;
                  component.OnButtonDrag -= Instance_OnButtonDrag_9;
               }
            }
         }
         
         Ray_testbuttom_previous = Ray_testbuttom;
         
         //setup new listeners
         if ( null != Ray_testbuttom )
         {
            {
               uScript_Button component = Ray_testbuttom.GetComponent<uScript_Button>();
               if ( null == component )
               {
                  component = Ray_testbuttom.AddComponent<uScript_Button>();
               }
               if ( null != component )
               {
                  component.OnButtonClick += Instance_OnButtonClick_9;
                  component.OnButtonDown += Instance_OnButtonDown_9;
                  component.OnButtonUp += Instance_OnButtonUp_9;
                  component.OnButtonEnter += Instance_OnButtonEnter_9;
                  component.OnButtonExit += Instance_OnButtonExit_9;
                  component.OnButtonDrag += Instance_OnButtonDrag_9;
               }
            }
         }
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( Head_Obj_previous != Head_Obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         Head_Obj_previous = Head_Obj;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( attach_obj_previous != attach_obj || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         attach_obj_previous = attach_obj;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_26 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_26 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_26 )
         {
            {
               uScript_Level component = event_UnityEngine_GameObject_Instance_26.GetComponent<uScript_Level>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_26.AddComponent<uScript_Level>();
               }
               if ( null != component )
               {
                  component.LevelWasLoaded += Instance_LevelWasLoaded_26;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != Ray_testbuttom )
      {
         {
            uScript_Button component = Ray_testbuttom.GetComponent<uScript_Button>();
            if ( null != component )
            {
               component.OnButtonClick -= Instance_OnButtonClick_9;
               component.OnButtonDown -= Instance_OnButtonDown_9;
               component.OnButtonUp -= Instance_OnButtonUp_9;
               component.OnButtonEnter -= Instance_OnButtonEnter_9;
               component.OnButtonExit -= Instance_OnButtonExit_9;
               component.OnButtonDrag -= Instance_OnButtonDrag_9;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_26 )
      {
         {
            uScript_Level component = event_UnityEngine_GameObject_Instance_26.GetComponent<uScript_Level>();
            if ( null != component )
            {
               component.LevelWasLoaded -= Instance_LevelWasLoaded_26;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_RaycastFromScreenPoint_uScriptAct_RaycastFromScreenPoint_3.SetParent(g);
      logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.SetParent(g);
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.SetParent(g);
      logic_uScriptAct_LoadPrefab_uScriptAct_LoadPrefab_15.SetParent(g);
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_19.SetParent(g);
      logic_uScriptAct_SetComponentsQuaternion_uScriptAct_SetComponentsQuaternion_21.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.FinishedSpawning += uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18;
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
      
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.FinishedSpawning -= uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18;
   }
   
   void Instance_OnButtonClick_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonClick_9( );
   }
   
   void Instance_OnButtonDown_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDown_9( );
   }
   
   void Instance_OnButtonUp_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonUp_9( );
   }
   
   void Instance_OnButtonEnter_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonEnter_9( );
   }
   
   void Instance_OnButtonExit_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonExit_9( );
   }
   
   void Instance_OnButtonDrag_9(object o, uScript_Button.ClickEventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_OnButtonDrag_9( );
   }
   
   void Instance_LevelWasLoaded_26(object o, uScript_Level.LevelWasLoadedEventArgs e)
   {
      //fill globals
      event_UnityEngine_GameObject_Scene_26 = e.Scene;
      event_UnityEngine_GameObject_LoadSceneMode_26 = e.LoadSceneMode;
      //relay event to nodes
      Relay_LevelWasLoaded_26( );
   }
   
   void uScriptAct_SpawnChildPrefabAtLocation_FinishedSpawning_18(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_18( );
   }
   
   void Relay_In_3()
   {
      {
         {
            logic_uScriptAct_RaycastFromScreenPoint_Camera_3 = Cam_Raycast;
            
         }
         {
            logic_uScriptAct_RaycastFromScreenPoint_ScreenPosition_3 = local_5_UnityEngine_Vector2;
            
         }
         {
         }
         {
         }
         {
         }
         {
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
      logic_uScriptAct_RaycastFromScreenPoint_uScriptAct_RaycastFromScreenPoint_3.In(logic_uScriptAct_RaycastFromScreenPoint_Camera_3, logic_uScriptAct_RaycastFromScreenPoint_ScreenPosition_3, logic_uScriptAct_RaycastFromScreenPoint_Distance_3, logic_uScriptAct_RaycastFromScreenPoint_layerMask_3, logic_uScriptAct_RaycastFromScreenPoint_include_3, logic_uScriptAct_RaycastFromScreenPoint_showRay_3, out logic_uScriptAct_RaycastFromScreenPoint_HitObject_3, out logic_uScriptAct_RaycastFromScreenPoint_HitDistance_3, out logic_uScriptAct_RaycastFromScreenPoint_HitLocation_3, out logic_uScriptAct_RaycastFromScreenPoint_HitNormal_3);
      hit_obj = logic_uScriptAct_RaycastFromScreenPoint_HitObject_3;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( hit_obj_previous != hit_obj || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            hit_obj_previous = hit_obj;
            
            //setup new listeners
         }
      }
      Hit_Pos = logic_uScriptAct_RaycastFromScreenPoint_HitLocation_3;
      Hit_Normal = logic_uScriptAct_RaycastFromScreenPoint_HitNormal_3;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_RaycastFromScreenPoint_uScriptAct_RaycastFromScreenPoint_3.Obstructed;
      
      if ( test_0 == true )
      {
         Relay_In_13();
      }
   }
   
   void Relay_In_4()
   {
      {
         {
            logic_uScriptAct_SetRandomVector2_MinX_4 = Ray_X_Min;
            
         }
         {
            logic_uScriptAct_SetRandomVector2_MaxX_4 = Ray_X_Max;
            
         }
         {
            logic_uScriptAct_SetRandomVector2_MinY_4 = Ray_Y_Min;
            
         }
         {
            logic_uScriptAct_SetRandomVector2_MaxY_4 = Ray_Y_Max;
            
         }
         {
         }
      }
      logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.In(logic_uScriptAct_SetRandomVector2_MinX_4, logic_uScriptAct_SetRandomVector2_MaxX_4, logic_uScriptAct_SetRandomVector2_MinY_4, logic_uScriptAct_SetRandomVector2_MaxY_4, out logic_uScriptAct_SetRandomVector2_TargetVector2_4);
      local_5_UnityEngine_Vector2 = logic_uScriptAct_SetRandomVector2_TargetVector2_4;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetRandomVector2_uScriptAct_SetRandomVector2_4.Out;
      
      if ( test_0 == true )
      {
         Relay_In_3();
      }
   }
   
   void Relay_OnButtonClick_9()
   {
   }
   
   void Relay_OnButtonDown_9()
   {
      Relay_In_4();
   }
   
   void Relay_OnButtonUp_9()
   {
   }
   
   void Relay_OnButtonEnter_9()
   {
   }
   
   void Relay_OnButtonExit_9()
   {
   }
   
   void Relay_OnButtonDrag_9()
   {
   }
   
   void Relay_In_13()
   {
      {
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( hit_obj_previous != hit_obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  hit_obj_previous = hit_obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_A_13 = hit_obj;
            
         }
         {
            {
               //if our game object reference was changed then we need to reset event listeners
               if ( Head_Obj_previous != Head_Obj || false == m_RegisteredForEvents )
               {
                  //tear down old listeners
                  
                  Head_Obj_previous = Head_Obj;
                  
                  //setup new listeners
               }
            }
            logic_uScriptCon_CompareGameObjects_B_13 = Head_Obj;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.In(logic_uScriptCon_CompareGameObjects_A_13, logic_uScriptCon_CompareGameObjects_B_13, logic_uScriptCon_CompareGameObjects_CompareByTag_13, logic_uScriptCon_CompareGameObjects_CompareByName_13, logic_uScriptCon_CompareGameObjects_ReportNull_13);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptCon_CompareGameObjects_uScriptCon_CompareGameObjects_13.Same;
      
      if ( test_0 == true )
      {
         Relay_In_19();
      }
   }
   
   void Relay_In_15()
   {
      {
         {
            logic_uScriptAct_LoadPrefab_name_15 = attach_prefab_pass;
            
         }
         {
         }
      }
      logic_uScriptAct_LoadPrefab_uScriptAct_LoadPrefab_15.In(logic_uScriptAct_LoadPrefab_name_15, out logic_uScriptAct_LoadPrefab_asset_15);
      attach_obj = logic_uScriptAct_LoadPrefab_asset_15;
      {
         //if our game object reference was changed then we need to reset event listeners
         if ( attach_obj_previous != attach_obj || false == m_RegisteredForEvents )
         {
            //tear down old listeners
            
            attach_obj_previous = attach_obj;
            
            //setup new listeners
         }
      }
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_FinishedSpawning_18()
   {
   }
   
   void Relay_In_18()
   {
      {
         {
            logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_18 = attach_prefab_name;
            
         }
         {
            logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_18 = attach_prefab_pass;
            
         }
         {
            logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_18 = Hit_Pos;
            
         }
         {
            logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_18 = local_20_UnityEngine_Quaternion;
            
         }
         {
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
      logic_uScriptAct_SpawnChildPrefabAtLocation_uScriptAct_SpawnChildPrefabAtLocation_18.In(logic_uScriptAct_SpawnChildPrefabAtLocation_PrefabName_18, logic_uScriptAct_SpawnChildPrefabAtLocation_ResourcePath_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnPosition_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnRotation_18, logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedName_18, logic_uScriptAct_SpawnChildPrefabAtLocation_Parent_18, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedGameObject_18, out logic_uScriptAct_SpawnChildPrefabAtLocation_SpawnedInstancedID_18, logic_uScriptAct_SpawnChildPrefabAtLocation_KeepWorldTransform_18);
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      
   }
   
   void Relay_In_19()
   {
      {
         {
            logic_uScriptAct_GetComponentsVector3_InputVector3_19 = Hit_Normal;
            
         }
         {
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_19.In(logic_uScriptAct_GetComponentsVector3_InputVector3_19, out logic_uScriptAct_GetComponentsVector3_X_19, out logic_uScriptAct_GetComponentsVector3_Y_19, out logic_uScriptAct_GetComponentsVector3_Z_19);
      local_22_System_Single = logic_uScriptAct_GetComponentsVector3_X_19;
      local_23_System_Single = logic_uScriptAct_GetComponentsVector3_Y_19;
      local_24_System_Single = logic_uScriptAct_GetComponentsVector3_Z_19;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_19.Out;
      
      if ( test_0 == true )
      {
         Relay_In_21();
      }
   }
   
   void Relay_In_21()
   {
      {
         {
            logic_uScriptAct_SetComponentsQuaternion_X_21 = local_22_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsQuaternion_Y_21 = local_23_System_Single;
            
         }
         {
            logic_uScriptAct_SetComponentsQuaternion_Z_21 = local_24_System_Single;
            
         }
         {
         }
         {
         }
      }
      logic_uScriptAct_SetComponentsQuaternion_uScriptAct_SetComponentsQuaternion_21.In(logic_uScriptAct_SetComponentsQuaternion_X_21, logic_uScriptAct_SetComponentsQuaternion_Y_21, logic_uScriptAct_SetComponentsQuaternion_Z_21, logic_uScriptAct_SetComponentsQuaternion_W_21, out logic_uScriptAct_SetComponentsQuaternion_OutputQuaternion_21);
      local_20_UnityEngine_Quaternion = logic_uScriptAct_SetComponentsQuaternion_OutputQuaternion_21;
      
      //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
      bool test_0 = logic_uScriptAct_SetComponentsQuaternion_uScriptAct_SetComponentsQuaternion_21.Out;
      
      if ( test_0 == true )
      {
         Relay_In_18();
      }
   }
   
   void Relay_LevelWasLoaded_26()
   {
      Relay_In_15();
   }
   
}
