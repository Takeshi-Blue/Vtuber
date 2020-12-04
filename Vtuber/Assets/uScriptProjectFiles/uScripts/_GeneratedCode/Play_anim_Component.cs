//uScript Generated Code - Build 1.1.3133
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the component script that you should assign to GameObjects to use this graph on them. Use the uScript/Graphs section of Unity's "Component" menu to assign this graph to a selected GameObject.

[AddComponentMenu("uScript/Graphs/Play_anim")]
public class Play_anim_Component : uScriptCode
{
   #pragma warning disable 414
   public Play_anim ExposedVariables = new Play_anim( ); 
   #pragma warning restore 414
   
   public UnityEngine.GameObject tmn_btn_obj { get { return ExposedVariables.tmn_btn_obj; } set { ExposedVariables.tmn_btn_obj = value; } } 
   public UnityEngine.GameObject anim_prefab { get { return ExposedVariables.anim_prefab; } set { ExposedVariables.anim_prefab = value; } } 
   public System.Single Anim_Time { get { return ExposedVariables.Anim_Time; } set { ExposedVariables.Anim_Time = value; } } 
   public UnityEngine.GameObject Close_Window { get { return ExposedVariables.Close_Window; } set { ExposedVariables.Close_Window = value; } } 
   
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
