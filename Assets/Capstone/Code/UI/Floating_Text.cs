using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Floating_Text : MonoBehaviour
{
    // Video reference: https://www.youtube.com/watch?v=fbUOG7f3jq8
    // Unity inspector attributes: https://www.youtube.com/watch?v=9udeBeQiZSc

    public Animator animator;
    TextMeshProUGUI textMeshPro;

    private void Start()
    {
        AnimatorClipInfo[] clipInfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipInfo[0].clip.length);
        textMeshPro = animator.GetComponent<TextMeshProUGUI>();

        if (!textMeshPro)
        {
            print("Text Mesh Pro is still missing from the object.");
        }
        else
        {
            print("Text mesh pro has been picked up.");
        }
    }

    public void SetText(string text)
    {
        if (!textMeshPro)
        {
            textMeshPro = animator.GetComponent<TextMeshProUGUI>();
            textMeshPro.text = "+" + text;
        }
        else
            textMeshPro.text = text;
    }
}
