using PlatformerMVC;
using UnityEngine;
using UnityEngine.Serialization;


namespace PlatformerMVC
{

    public class Main : MonoBehaviour
    {
        [SerializeField] private SpriteAnimatorConfig _playerConfig;
        [SerializeField] private int _animationSpeed = 10;
        [SerializeField] private LevelObjectView _playerView;

        private SpriteAnimatorController _playerAnimator;


        void Start()
        {
            _playerConfig = Resources.Load<SpriteAnimatorConfig>("SpriteAnimatorCfg");

            if (_playerConfig)
            {
                _playerAnimator = new SpriteAnimatorController(_playerConfig);
            }

            _playerAnimator.StartAnimation(_playerView._spriteRenderer, AnimState.Idle, true, _animationSpeed);
        }

        void Update()
        {
            _playerAnimator.Execute();
            Debug.Log("Update");
        }
    }
}
