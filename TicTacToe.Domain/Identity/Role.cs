using Microsoft.AspNetCore.Identity;
using TicTacToe.Domain.Common;

namespace TicTacToe.Domain.Identity;

public class Role : IdentityRole, IEntity<string>
{
    
}