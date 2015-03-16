﻿using UnityEngine;

namespace ModTools
{
    class GUIControls
    {

        static float fieldSize = 128;

        static public void FloatField(string name, ref float value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label(name);

            float oldValue = value;
            string oldValueString = value.ToString();
            string newValue = GUILayout.TextField(oldValueString, GUILayout.Width(fieldSize));

            if (oldValueString != newValue && !float.TryParse(newValue, out value))
            {
                value = oldValue;
            }

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

        static public void IntField(string name, ref int value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label(name);

            int oldValue = value;

            string newValue = GUILayout.TextField(value.ToString(), GUILayout.Width(fieldSize));
            if (!int.TryParse(newValue, out value))
            {
                value = oldValue;
            }

            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

        static public void StringField(string name, ref string value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label(name);
            value = GUILayout.TextField(value, GUILayout.Width(fieldSize));
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

        static public void BoolField(string name, ref bool value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label(name);
            value = GUILayout.Toggle(value, "");
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

        static public void Vector3Field(string name, ref Vector3 value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label("Vector3");
            GUILayout.Label(name);

            GUILayout.FlexibleSpace();
            FloatField("x", ref value.x);
            FloatField("y", ref value.y);
            FloatField("z", ref value.z);
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

        static public void Vector4Field(string name, ref Vector4 value)
        {
            GUI.contentColor = Color.white;
            GUILayout.BeginHorizontal();
            GUILayout.Label("Vector4");
            GUILayout.Label(name);

            GUILayout.FlexibleSpace();
            FloatField("x", ref value.x);
            FloatField("y", ref value.y);
            FloatField("z", ref value.z);
            FloatField("w", ref value.w);
            GUILayout.EndHorizontal();
            GUI.contentColor = Color.white;
        }

    }

}