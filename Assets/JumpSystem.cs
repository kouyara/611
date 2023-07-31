using UnityEngine;

public class JumpSystem : MonoBehaviour
{
    //ジャンプの速度を設定
    private const float _velocity =  200.0f;

    private Rigidbody _rigidbody;
    //着地状態を管理
    private bool _isGrounded;

    void Start()
    {
        //Rigidbodyコンポーネントを取得
        _rigidbody = this.gameObject.GetComponent<Rigidbody>();
        //最初は着地していない状態
        _isGrounded = false;
    }

    void Update()
    {
        // A Button押下中
        bool a_button = OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch);
        // B Button押下中
        bool b_button = OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch);

        //着地しているかを判定
        if (_isGrounded == true)
        {

            //AボタンまたはBボタンが押されているかを判定
            if (a_button || b_button)
            { //AボタンまたはBボタンが押されていたらジャンプの動作をする。

                //ジャンプの方向を上向きのベクトルに設定
                Vector3 jump_vector = Vector3.up;
                //ジャンプの速度を計算
                Vector3 jump_velocity = jump_vector * _velocity;

                //上向きの速度を設定
                _rigidbody.velocity = jump_velocity;
                //地面から離れるので着地状態を書き換え
                _isGrounded = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //着地を検出したので着地状態を書き換え
        _isGrounded = true;
    }
}