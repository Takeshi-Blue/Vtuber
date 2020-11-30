//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/randomraycast_addobj")]
public class randomraycast_addobj_Component : uScriptCode
{
   #pragma warning disable 414
   public randomraycast_addobj ExposedVariables = new randomraycast_addobj( ); 
   #pragma warning restore 414
   
   public UnityEngine.Vector3 Hit_Pos { get { return ExposedVariables.Hit_Pos; } set { ExposedVariables.Hit_Pos = value; } } 
   public UnityEngine.Vector3 Hit_Normal { get { return ExposedVariables.Hit_Normal; } set { ExposedVariables.Hit_Normal = value; } } 
   public UnityEngine.Camera Cam_Raycast { get { return ExposedVariables.Cam_Raycast; } set { ExposedVariables.Cam_Raycast = value; } } 
   public System.Single Ray_X_Max { get { return ExposedVariables.Ray_X_Max; } set { ExposedVariables.Ray_X_Max = value; } } 
   public System.Single Ray_Y_Max { get { return ExposedVariables.Ray_Y_Max; } set { ExposedVariables.Ray_Y_Max = value; } } 
   public UnityEngine.GameObject hit_obj { get { return ExposedVariables.hit_obj; } set { ExposedVariables.hit_obj = value; } } 
   public UnityEngine.GameObject Ray_testbuttom { get { return ExposedVariables.Ray_testbuttom; } set { ExposedVariables.Ray_testbuttom = value; } } 
   public System.Single Ray_X_Min { get { return ExposedVariables.Ray_X_Min; } set { ExposedVariables.Ray_X_Min = value; } } 
   public System.Single Ray_Y_Min { get { return ExposedVariables.Ray_Y_Min; } set { ExposedVariables.Ray_Y_Min = value; } } 
   public UnityEngine.GameObject Head_Obj { get { return ExposedVariables.Head_Obj; } set { ExposedVariables.Head_Obj = value; } } 
   public UnityEngine.GameObject attach_obj { get { return ExposedVariables.attach_obj; } set { ExposedVariables.attach_obj = value; } } 
   public System.String attach_prefab_name { get { return ExposedVariables.attach_prefab_name; } set { ExposedVariables.attach_prefab_name = value; } } 
   public System.String attach_prefab_pass { get { return ExposedVariables.attach_prefab_pass; } set { ExposedVariables.attach_prefab_pass = value; } } 
   
   void Awake( )
   {
      #if !(UNITY_FLASH)
      useGUILayout = false;
      #endif
      ExposedVariables.Awake( );
      ExposedVariables.SetParent( this.gameObject );
      if ( "1.CMR" != uScript_MasterComponent.Version )
      {
         uScriptDebug.Log( "The generated code is not compatible with your current uScript Runtime " + uScript_MasterComponent.Version, uScriptDebug.Type.Error );
         ExposedVariables = null;
         UnityEngine.Debug.Break();
      }
   }
   void Start( )
   {
      ExposedVariables.Start( );
   }
   void OnEnable( )
   {
      ExposedVariables.OnEnable( );
   }
   void OnDisable( )
   {
      ExposedVariables.OnDisable( );
   }
   void Update( )
   {
      ExposedVariables.Update( );
   }
   void OnDestroy( )
   {
      ExposedVariables.OnDestroy( );
   }
   #if UNITY_EDITOR
      void OnDrawGizmos( )
      {
      }
   #endif
}
