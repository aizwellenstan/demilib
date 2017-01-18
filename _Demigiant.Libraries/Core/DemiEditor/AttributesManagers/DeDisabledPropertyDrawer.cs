﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2017/01/16 17:44
// License Copyright (c) Daniele Giardini

using DG.DemiLib.Attributes;
using UnityEditor;
using UnityEngine;

namespace DG.DemiEditor.AttributesManagers
{
    [CustomPropertyDrawer(typeof(DeDisabledAttribute))]
    public class DeDisabledPropertyDrawer : DecoratorDrawer
    {
        public override float GetHeight() { return 0; }

        public override void OnGUI(Rect position)
        {
            DeDisabledAttribute attr = (DeDisabledAttribute)attribute;
            bool isTrue = attr.condition.IsTrue(DeGlobalInspector.I.serializedObject);

            bool wasGUIEnabled = GUI.enabled;
            EditorGUI.EndDisabledGroup();
            EditorGUI.BeginDisabledGroup(isTrue || !wasGUIEnabled);
//            EditorGUI.BeginDisabledGroup(false);
//            EditorGUI.EndDisabledGroup();
        }
    }
}