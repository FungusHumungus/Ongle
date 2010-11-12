
using System;
using System.Collections.Generic;

namespace Ongle
{

	public interface IBlockParser
	{
	 	Block GetBlock ( IScope scope, Tokens tokens );
		void ParseBlock ( Block block, Tokens tokens );
		Expression ParseExpression ( IScope block, Tokens tokens );
	}
}
