namespace MauiGroupedCollectionViewBug;

public class MainPageViewModel
{
	public MainPageViewModel()
	{

		this.Items = new List<ModelGroup>
		{
			new ModelGroup("Group 1", CreateModels(10)),
            new ModelGroup("Group 2", CreateModels(10)),
            new ModelGroup("Group 3", CreateModels(10)),
            new ModelGroup("Group 4", CreateModels(10)),
        };

	}

	public List<ModelGroup> Items { get; }

	private static IEnumerable<Model> CreateModels(int count)
	{
		var models = new List<Model>();
		for (int i = 0; i < count; i++)
		{
			models.Add(new Model
			{
				Text = $"Item {i}"
			});
		}
		return models;
	}
}

public class ModelGroup : List<Model>
{
	public ModelGroup(string name, IEnumerable<Model> items)
		: base(items)
	{
        this.Name = name;
    }

    public string Name { get; }
}

public class Model
{
	public string Text { get; init; }
}
