using FluentValidation;
using InformationBoilerAPI.Domain.Entities.Dto_s.UserDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.Validators
{
    public class UserUpdateValidator : AbstractValidator<UserUpdateDto>
    {
        public UserUpdateValidator()
        {
            RuleFor(x => x.Name).Must(OnlyStringValue);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Phone).Must(PhoneNumber);
            RuleFor(x => x.Country).Must(OnlyStringValue);
            RuleFor(x => x.City).Must(OnlyStringValue);
            RuleFor(x => x.DateOfBirth).Must(DateOfBirth);
        }
        bool OnlyStringValue(string city)
        {
            Regex rgx = new Regex("^[A-Za-z]$");
            return rgx.IsMatch(city);
        }
        bool PhoneNumber(string phone)
        {
            Regex rgx = new Regex("^+(9[976]\\d|8[987530]\\d|6[987]\\d|5[90]\\d|42\\d|3[875]\\d|\r\n2[98654321]\\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|\r\n4[987654310]|3[9643210]|2[70]|7|1)\\d{1,14}$");
            return rgx.IsMatch(phone);
        }
        bool DateOfBirth(DateTime birth)
        {
            int max = DateTime.Now.Year;
            int min = DateTime.Now.Year - 120;
            return birth.Year <= max && birth.Year >= min
                ? true
                : false;

        }
    }
}
