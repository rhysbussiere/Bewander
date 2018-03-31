[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(int postid, [Bind(Include = "FlagID,FlagStatus")] Flag flag)
{
    var flagdata = from FlagOption f in Enum.GetValues(typeof(FlagOption))
                    select new
                    {
                        type = (int)f
                    };
                 
    flag.DateFlagged = DateTime.Now;

    flag.Post_ID = postid

    string user = User.Identity.GetUserId();
    flag.User_ID = user;

    if (ModelState.IsValid)
    {
        db.Flags.Add(flag);
        db.SaveChanges();
        return Redirect(Request.UrlReferrer.ToString());
    }

    return View(flag);
}
