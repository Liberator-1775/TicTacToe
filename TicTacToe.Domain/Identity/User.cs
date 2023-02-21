using Microsoft.AspNetCore.Identity;
using TicTacToe.Domain.Common;

namespace TicTacToe.Domain.Identity;

public class User : IdentityUser, IEntity<string>
{
    
}