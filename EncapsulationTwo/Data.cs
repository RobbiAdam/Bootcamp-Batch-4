namespace EncapsulationTwo;

class Data
{
    private string _gun;
    private int _bullet;
    // private bool _automatic;

    public Data(string gun, int bullet)
    {
        _gun = gun;
        _bullet = bullet;
    }

    public string GetGun()
    {
        return _gun;
    }
    public string SetGun(string gun)
    {
        _gun = gun;
        return _gun;
    }

    public int GetBullet()
    {
        return _bullet;
    }

    public int SetBullet(int bullet)
    {
        _bullet = bullet;
        return _bullet;
    }

    public bool GetAutomatic()
    {
        if (_bullet > 12)
        {
            return true;
        }
        return false;
    }



}
