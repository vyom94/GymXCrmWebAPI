using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CRM.Core.Extension
{
    public static class EnumExtensions
    {
        public static string GetFriendlyName(this Enum e)
        {
            DescriptionAttribute attribute = GetAttributeOrDefault<DescriptionAttribute>(e);

            string name = Enum.GetName(e.GetType(), e);
            if (name != null)
            {
                if (attribute != null)
                {
                    return attribute.Description;
                }
                return Enum.GetName(e.GetType(), e);
            }

            return string.Empty;
        }
        public static T GetAttributeOrDefault<T>(this Enum e) where T : System.Attribute
        {
            var firstOrDefault = e
                .GetType()
                .GetMember(e.ToString())
                .FirstOrDefault(member => member.MemberType == MemberTypes.Field);
            if (firstOrDefault != null)
            {
                T attribute = firstOrDefault
                    .GetCustomAttributes(typeof(T), false)
                    .Cast<T>()
                    .SingleOrDefault();

                return attribute;
            }

            return null;
        }
    }
    }
