using System;
using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    public class GridEvents
    {
        public UnityAction<Bounds> GridLoaded;
        public UnityAction InputStart;
        public UnityAction InputStop;
        public UnityAction<int> MatchGroupDespawn;
        public UnityAction<int> ScoreMultiChanged;
        public UnityAction<int> PowerUpDestroyScore;
        public Func<GameObject, GameObject> InsRequest;
        public UnityAction IncScoreMulti;
        public UnityAction ResetScoreMulti;
    }
}