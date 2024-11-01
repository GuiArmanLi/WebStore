namespace src.store.domain.entities;

public class Comment(Guid idUser, string title, string description) : BaseEntitiy
{
    private Guid IdUser { get; init; } = idUser;
    private string Title { get; set; } = title;
    private string Description { get; set; } = description;

    private int UpVotes { get; set; }
    private int DownVotes { get; set; }
}