using System;
using LitMotion;
using UnityEngine;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class TweenComeFromBelow : MonoBehaviour
    {
        public Vector2 startPosition;
        public Vector2 endPosition;
        public float duration;
        public Ease ease;

        private void Start()
        {
            LMotion.Create(startPosition, endPosition, duration);
        }
    }
}