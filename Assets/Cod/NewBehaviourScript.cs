using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    List<Animator> _animators;              // Yazı Animasyonları
    public float arasında=0.15f;
    void Start()
    {
        _animators = new List<Animator>(GetComponentsInChildren<Animator>());
        StartCoroutine(Gelen());
    }

    IEnumerator Gelen()
    {
        while(true)
        {
            foreach (var animator in _animators)
            {
                animator.SetTrigger("Gelen");           // gelen anımasyonu çağır
                yield return new WaitForSeconds(arasında);
            }
        }

    }
}
