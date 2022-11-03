namespace HotelManagement.Domain.Models.OptionSets
{
    public enum RoomTypeEnum
    {
        Single,
        Twin,
        Double,
        Triple,
        Quad
    }

    public enum StatusEnum
    {
        New,
        Active,
        Completed,
        Canceled
    }

    public enum UserRoleEnum
    {
        SuperAdministrator,
        Administrator,
        Premium,
        Gold,
        Silver,
        Basic
    }
}