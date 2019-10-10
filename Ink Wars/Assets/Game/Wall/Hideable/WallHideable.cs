using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHideable : Wall
{
    [SerializeField]
    private WallStage initialStage = WallStage.Visible;

    private WallStage stage;
    public WallStage Stage
    {
        get
        {
            return stage;
        }
        set
        {
            stage = value;
            OnChangeWallStage(stage);
        }
    }

    private delegate void ChangeWallStage(WallStage newStage);
    private ChangeWallStage OnChangeWallStage = delegate { };

    private Animator animator;

    private Dictionary<WallStage, string> pairs = new Dictionary<WallStage, string>()
    {
        { WallStage.Hide, "Hide" }, { WallStage.Visible, "Show" }
    };

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        TerritorialLevelManager.OnActivateWallsBehaviour += ChangeStage;

        OnChangeWallStage += PlayAnimation;
    }

    private void OnDisable()
    {
        TerritorialLevelManager.OnActivateWallsBehaviour -= ChangeStage;

        OnChangeWallStage -= PlayAnimation;
    }

    private void Start()
    {
        Stage = initialStage;
    }

    private void ChangeStage()
    {
        WallStage _stage = (WallStage)Random.Range(0, 2);

        if (_stage != Stage)
        {
            Stage = _stage;
        }
    }

    private void PlayAnimation(WallStage stage)
    {
        animator.Play(pairs[stage]);
    }
}

public enum WallStage
{
    Hide, Visible
}
