using UnityEngine;

public enum CharacterModel { X, Y }
public enum CharacterStage
{
    Tpose,
    Idel,
    Walk,
    Run,
    Jump,
    Fall
}

public abstract class Character : MonoBehaviour
{
    [Header("Basic")]
    #region Basic
    public CharacterModel characterModel;
    public GameObject model {  get; private set; }
    public CharacterStage characterStage { get; private set; }
    public float speed;
    public float gravity;
    private const float startingY = 1;


    #endregion

    [Header("Input")]
    #region Input
    public InPutAction inPutAction = new InPutAction(new InPutDevice());

    #endregion


    public virtual void CharacterInit()
    {
        if (model != null) Destroy(model);
        GameObject buildModel =
            characterModel == CharacterModel.X ?
            Resources.Load<GameObject>("3DModel/X_Bot") :
            Resources.Load<GameObject>("3DModel/Y_Bot");
        model = Instantiate(buildModel, transform);
        characterStage = CharacterStage.Tpose;



    }
}
