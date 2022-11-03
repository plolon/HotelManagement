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
        Administraor,
        Premium,
        Gold,
        Silver,
        Basic
    }
}