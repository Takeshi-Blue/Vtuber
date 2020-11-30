//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/DB_state")]
public class DB_state_Component : uScriptCode
{
   #pragma warning disable 414
   public DB_state ExposedVariables = new DB_state( ); 
   #pragma warning restore 414
   
   public System.Single DB_CountTime { get { return ExposedVariables.DB_CountTime; } set { ExposedVariables.DB_CountTime = value; } } 
   public System.Single DB_CountTime_Min { get { return ExposedVariables.DB_CountTime_Min; } set { ExposedVariables.DB_CountTime_Min = value; } } 
   public System.Single DB_CountTime_Hour { get { return ExposedVariables.DB_CountTime_Hour; } set { ExposedVariables.DB_CountTime_Hour = value; } } 
   public UnityEngine.GameObject DB_obj_txt_min { get { return ExposedVariables.DB_obj_txt_min; } set { ExposedVariables.DB_obj_txt_min = value; } } 
   public UnityEngine.GameObject DB_obj_txt_hour { get { return ExposedVariables.DB_obj_txt_hour; } set { ExposedVariables.DB_obj_txt_hour = value; } } 
   public System.Single DB_CountTime_sec { get { return ExposedVariables.DB_CountTime_sec; } set { ExposedVariables.DB_CountTime_sec = value; } } 
   public UnityEngine.GameObject DB_obj_txt_sec { get { return ExposedVariables.DB_obj_txt_sec; } set { ExposedVariables.DB_obj_txt_sec = value; } } 
   
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
