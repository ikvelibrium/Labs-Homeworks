using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class CustomEditorSO : ScriptableObject
{
    [SerializeField] private ContentType _contentType;
    [SerializeField] private List<AudioClass> _dangerAudios = new List<AudioClass>();
    [SerializeField] private List<AudioClass> _friendlyAudios = new List<AudioClass>();
    [SerializeField] private List<AudioClass> _neutralAudios = new List<AudioClass>();
    [SerializeField] private string _id;
    [SerializeField] private string _text;


    public enum ContentType
    {
        Danger = 0,
        Friendly = 1,
        Neutral = 2
    }


    [CustomEditor(typeof(CustomEditorSO))]
    public class CustiomEditoer : Editor
    {
        SerializedProperty audio_id;
        SerializedProperty audio_enum;
        SerializedProperty audio_list;
        SerializedProperty audio_type;
        string audiolist_text;

        bool isList;
        bool isText;

        public override void OnInspectorGUI()
        {
            audio_id = serializedObject.FindProperty("_id");
            EditorGUILayout.PropertyField(audio_id, new GUIContent("ID"));
            
            CreateButtons();
            

            if (isList == true)
            {
                CreateList();
            }
            if (isText == true)
            {
                audiolist_text = serializedObject.FindProperty("_text").stringValue;
                EditorGUILayout.TextArea(audiolist_text, GUILayout.Height(80));
            }
            
            serializedObject.ApplyModifiedProperties();
        }
        public void CreateList()
        {
            audio_enum = serializedObject.FindProperty("_contentType");
            EditorGUILayout.PropertyField(audio_enum, new GUIContent("Enum"));


            
           switch (audio_enum.intValue)
            {
               case 0 :
                   audio_list = serializedObject.FindProperty("_dangerAudios");
                   EditorGUILayout.PropertyField(audio_list, new GUIContent("DangerAudios"));
                   break;
               case 1 :
                   audio_list = serializedObject.FindProperty("_friendlyAudios");
                   EditorGUILayout.PropertyField(audio_list, new GUIContent("FriendlyAudios"));
                   break;
               case 2 :
                   audio_list = serializedObject.FindProperty("_neutralAudios");
                   EditorGUILayout.PropertyField(audio_list, new GUIContent("NeutralAudios"));
                   break; 
            } 

        }

        public void CreateButtons()
        {
            EditorGUILayout.BeginVertical();
            if (GUILayout.Button("List"))
            {
                isList = true;
                isText = false;
            }
            if (GUILayout.Button("Text"))
            {
                isText = true;
                isList = false;
            }
            
            EditorGUILayout.EndVertical();
        }

    }
    
}
