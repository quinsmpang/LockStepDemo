using UnityEngine;

public class AI_Debug_Shoot : AIState
{
	public AI_Debug_Shoot(AISystem owner)
		:base(owner)
	{
		m_eType = AIState.Type.eDebug_Shoot;
	}
	
	override public void OnEnter ( AIState lastState )
	{
		m_player.m_toSkillInstance = ShootHelper.ShootByArea(m_player, m_match);

		m_player.m_bForceShoot = true;
	}
	
	override public void Update (IM.Number fDeltaTime)
	{
		if( m_player.m_StateMachine.m_curState.m_eState != PlayerState.State.eShoot &&
			m_player.m_StateMachine.m_curState.m_eState != PlayerState.State.ePrepareToShoot)
			m_system.SetTransaction(AIState.Type.eDebug_Init);
	}
	
	override public void OnExit ()
	{
		m_player.m_toSkillInstance = null;
	}
}