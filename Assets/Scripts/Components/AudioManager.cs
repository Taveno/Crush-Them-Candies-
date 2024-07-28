using System.Collections;
using System.Collections.Generic;
using Events;
using Extensions.Unity.MonoHelper;
using UnityEngine;
using Zenject;

public class AudioManager : EventListenerMono
{
    [Inject] private AudioEvents AudioEvents { get; set; }
    [SerializeField] private AudioClip moveSound;
    [SerializeField] private AudioClip tileMovementSound;
    [SerializeField] private AudioClip horizontalPowerupSound;
    [SerializeField] private AudioClip verticalPowerupSound;
    [SerializeField] private AudioClip bombPowerupSound;

    protected override void RegisterEvents()
    {
        AudioEvents.PlayMove += OnPlayMoveSound;
        AudioEvents.PlayBombPowerUp += OnPlayBombPowerUp;
        AudioEvents.PlayHorizontalPowerUp += OnPlayHorizontalPowerUp;
        AudioEvents.PlayVerticalPowerUp += OnPlayVerticalPowerUp;
    }

    private void OnPlayMoveSound()
    {
        AudioSource.PlayClipAtPoint(tileMovementSound, Vector3.zero);
    }

    private void OnPlayVerticalPowerUp()
    {
        AudioSource.PlayClipAtPoint(verticalPowerupSound, Vector3.zero);
    }

    private void OnPlayHorizontalPowerUp()
    {
        AudioSource.PlayClipAtPoint(horizontalPowerupSound, Vector3.zero);
    }

    private void OnPlayBombPowerUp()
    {
        AudioSource.PlayClipAtPoint(bombPowerupSound, Vector3.zero);
    }

    protected override void UnRegisterEvents()
    {
        AudioEvents.PlayMove -= OnPlayMoveSound;
        AudioEvents.PlayBombPowerUp -= OnPlayBombPowerUp;
        AudioEvents.PlayHorizontalPowerUp -= OnPlayHorizontalPowerUp;
        AudioEvents.PlayVerticalPowerUp -= OnPlayVerticalPowerUp;
    }
}