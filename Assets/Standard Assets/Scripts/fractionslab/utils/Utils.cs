﻿using System;
using System.Collections.Generic;
using UnityEngine;
using SBS.Math;

namespace fractionslab.utils
{

    public enum configurationName
    {
        lab = 0,
        lines,
        rectangles,
        sets,
        liquids,
        change_color,
        copy,
        find_equivalence,
        find_parent,
        highlight,
        add,
        subtract
    }

       public enum InteractionMode
    {
        Initializing = 0,
        Moving,
        Changing,
        Partitioning,
        Scaling,
        Freeze,
        LookAt,
        Wait
       
    }

    public enum ActionType
    {
        Join = 0,
        TakingAway,
        Compare
    }

    public enum FractionPart
    {
        Numerator = 0,
        Denominator
    }

    public enum ElementsType
    {
        VRect = 0,
        HRect,
        Line,
        Liquid,
        Arrow,
        Highlight,
        Set,
        MoonSet,
        HeartSet,
        StarSet
    }

    public enum ElementsState
    {
        Fraction = 0,
        Cut,
        Result,
        Equivalence,
        Improper
    }

    public enum TaskState
    {
        New = 0,
        Visited,
        Locked
    }

    public struct Task
    {
        public string id;
        public string title;
        public string description;
        public TaskState taskState;
        public int number;
    }

    public struct SliceVertex 
    {
        public int[] vertex;
        public bool isColored;
    }
    public struct BBExtend
    {
        public float left;
        public float right;
        public float top;
        public float bottom;

        public BBExtend(float l, float t, float r, float b)
        {
            left = l;
            right = r;
            top = t;
            bottom = b;
        }
    }

    public struct Element
    {
        public int numerator;
        public int denominator;
        public int partNumerator;
        public int partDenominator;
        public int partitions;
        public ElementsState state;
        public ElementsType type;
        public InteractionMode mode;
        public SBSVector3 position;
        public int shape;
        public Color color;
    }

    public class Tweener
    {
        static protected List<GameObject> tweenGOList = new List<GameObject>();

        protected static iTweenAnimator CreateNewTween()
        {
            GameObject GO = new GameObject("tweenGO");
            iTweenAnimator tween = GO.AddComponent<iTweenAnimator>();

            tweenGOList.Add(GO);
            return tween;
        }

        public static iTweenAnimator CreateNewTween(Vector3 from, Vector3 to, float time, string easeType, float delay, Action<object> onStart, Action<object> onUpdate, Action<object> onComplete, bool reset = false)
        {
           // Debug.Log("CreateNewTween "+ time);
            iTweenAnimator tween = CreateNewTween();
            tween.onStart = onStart;
            tween.onUpdate = onUpdate;
            tween.onComplete = onComplete;
            iTween.ValueTo(tween.gameObject, iTween.Hash("from", from, "to", to,
                "time", time, "easeType", easeType, "loopType", "none", "delay", delay,
                "onstart", (Action<object>)tween.onStart, "onupdate", (Action<object>)tween.onUpdate, "oncomplete", (Action<object>)tween.onComplete));

            if (reset)
                tween.onUpdate((object)from);
            return tween;
        }

        public static void StopAndDestroyAllTweens()
        {
            if (tweenGOList == null)
                return;

            iTween.Stop();

            for (int i = tweenGOList.Count - 1; i >= 0; --i)
            {
                GameObject.DestroyImmediate(tweenGOList[i]);
                tweenGOList.RemoveAt(i);
            }
            tweenGOList.Clear();
        }
    }
}
