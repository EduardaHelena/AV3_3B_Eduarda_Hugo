using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
public class Editor : MonoBehaviour {

    [CustomPropertyDrawer(typeof(PotionSelectorAttribute))]
    public class PotionSelectorDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            int index = 0;
            string[] names = new string[PotionDB.Instance.potions.Length];
            int[] heals = new int[PotionDB.Instance.potions.Length];
         

            for (int i = 0; i < PotionDB.Instance.potions.Length; i++)
            {
                names[i] = PotionDB.Instance.potions[i].name;
                heals[i] = PotionDB.Instance.potions[i].heal;

               

                if (names[i] == property.stringValue)
                {
                    index = i;
                }

            }

            Rect popupRect = new Rect(position);
            popupRect.xMax -= 64;

            index = EditorGUI.Popup(popupRect, label.text, index, names);
            property.stringValue = names[index];

            Rect healRect = new Rect(position);
            healRect.xMin = popupRect.xMax;

            EditorGUI.IntField(healRect, heals[index]);

            string heals1 = heals.ToString();
            // index1 = EditorGUI.Label(position, index1, heals1);
            //   property.stringValue = heals1[index1];
          //  EditorGUILayout.TextField(heals[index].ToString());
            //EditorGUILayout.TextField(heals[index].ToString());
        }
    }
}
