public enum Mail
{
    DNR    
}

public enum MailStatus
{
    Success,
    NotConfigure,
    Failed
}

public enum Act
{
    LOGIN,
    LOGOUT
}

public enum Directories
{
    profileimages,
    documents
}

public enum SortCurators
{
    NoSort = 1,
    FollowersLowToHigh,
    FollowersHighToLow,
    CreditsLowToHigh,
    CreditsHighToLow
}