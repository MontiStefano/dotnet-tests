using System;
using System.Collections.Generic;
using System.Text;
using Application.Interfaces;
using Application.Models;
using Domain.Interfaces;


namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();

            var userDtos = users.Select(user => new UserDto
            {
                Id = user.Id,
                FullName = user.Name + " " + user.LastName,
                Email = user.Email,
                CreationDate = user.CreationDate
            }).ToList();

            return userDtos;
        }
    }
}
