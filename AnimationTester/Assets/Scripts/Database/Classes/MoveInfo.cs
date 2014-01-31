using Mobamon.Database.Enums;

namespace Mobamon.Database.Classes
{
	public struct MoveInfo
	{
		public float damage;
		public AttackCategory attackCategory;
		public TargetType targetType;
		public AttackSource attackSource;
		
		public bool isImmobilizing;
		public bool isFollowing;
		public bool isProjectile;
	}
}

