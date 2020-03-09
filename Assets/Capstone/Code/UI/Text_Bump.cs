using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace TeamMars.Capstone
{

    public class Text_Bump : MonoBehaviour
    {
        [Header("Bump")]
        /// whether or not the bar should "bump" when changing value
        public bool BumpScaleOnChange = true;
        /// the duration of the bump animation
        public float BumpDuration = 0.2f;
        /// the curve to map the bump animation on
        public AnimationCurve BumpAnimationCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);
        /// whether or not the bar is bumping right now
        public bool Bumping { get; protected set; }

        protected float _targetFill;
        protected Vector3 _targetLocalScale = Vector3.one;
        protected float _newPercent;
        protected float _lastUpdateTimestamp;
        protected bool _bump = false;
        protected Vector3 _initialScale;
        protected Vector3 _newScale;

        protected Image _foregroundImage;
        protected Image _delayedImage;
        protected bool _initialized;

        protected TextMeshProUGUI textMeshPro;

        protected Color originalColor;
        public Color positiveColor;
        public Color negativeColor;

        public bool colorChangingPositive;

        public static Text_Bump Instance;

        /// <summary>
        /// On start we store our image component
        /// </summary>
        protected virtual void Start()
        {
            _initialScale = transform.localScale;

            _initialized = true;

            if (Instance == null) Instance = this;

            textMeshPro = GetComponent<TextMeshProUGUI>();

            originalColor = textMeshPro.color;
        }

        /// <summary>
        /// Triggers a camera bump
        /// </summary>
        public virtual void Bump()
        {
            if (!BumpScaleOnChange || !_initialized)
            {
                return;
            }
            if (gameObject.activeInHierarchy)
            {
                StartCoroutine(BumpCoroutine());
            }
        }

        /// <summary>
        /// A coroutine that (usually quickly) changes the scale of the bar 
        /// </summary>
        /// <returns>The coroutine.</returns>
        protected virtual IEnumerator BumpCoroutine()
        {
            float journey = 0f;
            Bumping = true;

            while (journey <= BumpDuration)
            {
                journey = journey + Time.deltaTime;
                float percent = Mathf.Clamp01(journey / BumpDuration);
                float curvePercent = BumpAnimationCurve.Evaluate(percent);
                transform.localScale = curvePercent * _initialScale;

                if(colorChangingPositive == true)
                    textMeshPro.color = Color.Lerp(positiveColor, originalColor, (journey / BumpDuration));
                else
                    textMeshPro.color = Color.Lerp(negativeColor, originalColor, (journey / BumpDuration));


                yield return null;
            }
            Bumping = false;
            colorChangingPositive = false;
            yield return null;
        }
    }
}
