using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Roof : MonoBehaviour
{
    [SerializeField] private PrintWall _printWall;
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private GameObject _roof;
    [SerializeField] private ParticleSystem _win;

    private void OnEnable()
    {
        _roof.SetActive(false);

        _printWall.BuildEnded += OnBuildEnd;
    }

    private void OnDisable()
    {
        _printWall.BuildEnded -= OnBuildEnd;
    }

    private void OnBuildEnd()
    {
        _roof.SetActive(true);
        _roof.transform.DOMoveY(_targetPosition.position.y, 1);
        _win.Play();
    }
}
