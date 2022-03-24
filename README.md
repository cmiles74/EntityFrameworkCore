# Nervestaple.EntityFrameworkCore

This project provides library code to make it easier to code up repositories
backed by databases using [Microsoft's EntityFrameworkCore library][1].
All of the code needed to handle the icky stuff has already been coded up, all
you need to do is write up the "entity" class and extend the provided 
repositories. You may use the [fluent API][2] if you prefer but these examples
use annotations.

```cs
public class ToDoItem : Entity<long>
{
    public override long? Id { get; set; }
    
    public long? ToDoContextId { get; set; }
    
    [ForeignKey("ToDoContextId")]
    public ToDoContext ToDoContext { get; set; }
    
    ...
}
```

In this example we extent the provided `Entity` class and specify the unique
identifier column type (`long`) and then code up the properties, including an
example relationship. We also have the concept of an `EditModel`, this is in
place to support situations where you have an entity with many fields but not
all of them are editable (i.e. collection properties).

```cs
public class ToDoItemEdit : EditModel<ToDoItem, long>
{
    /// <summary>
    /// Unique ID of the instance
    /// </summary>
    public long? Id { get; set; }
    
    /// <summary>
    /// The unique ID of this instance's context
    /// </summary>
    public long? ToDoContextId { get; set; }
    ...
}
```

You may also code up `Criteria` and `Parameter` classes to get searching of 
entity fields by string, date range, numeric range, etc.

With that out of the way, we can code up our repository. In real-life you'd
probably have an interface for your repository as well.

```cs
public class ToDoItemRepository : ToDoReadWriteRepository<ToDoItem, long>, IToDoItemRepository
{
    public ToDoItemRepository(ToDoDbContext context) : base(context)
    {
        
    }
}
```

We extend the provided repository and fill in our context. You get the CRUD
methods for free! We have a larger (and runnable) example you can look at to
get a better idea how things work for real.

* Nervestaple WebAPI To Do Example REST service

This library is a work in progress, please feel free to fork and send me pull
requests! `:-D`

## Documentation

This project uses [Doxygen] for documentation. Doxygenn will collect 
inline comments from your code, along with any accompanying README files, and 
create a documentation website for the project. If you do not have Doxygen 
installed, you can download it from their website and place it on your path. 
To run Doxygen...

    doxygen

The documentation will be written to the `doc/html` folder at the root of the 
project, you can read this documentation with your web browser.

The current version of this documentation is available through the GitLab
project.

## Other Notes

Project Icon made by [Freepik](https://www.freepik.com/) from 
[Flaticon](https://www.flaticon.com/) under the 
[Creative Commons license](http://creativecommons.org/licenses/by/3.0/).

----

[1]: https://docs.microsoft.com/en-us/ef/core/
[2]: https://docs.microsoft.com/en-us/ef/core/modeling/#use-fluent-api-to-configure-a-model
[4]: http://www.doxygen.nl/
