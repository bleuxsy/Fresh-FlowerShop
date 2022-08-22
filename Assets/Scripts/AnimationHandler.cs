using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationHandler : MonoBehaviour
{
    private Animator m_Animator;
    void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }
    public void EnterNextScene()
    {
        m_Animator.Play("LoadingAm");
    }
    public void OnEnterNextScene()
    {
        SceneManager.LoadScene("MG-Finish");
    }
}