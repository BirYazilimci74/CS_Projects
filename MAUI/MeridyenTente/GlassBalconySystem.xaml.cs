namespace MeridyenTente;

public partial class GlassBalconySystem : ContentPage
{
    public GlassBalconySystem()
	{
		InitializeComponent();
	}

	public void CalculateGlassSize(object sender, EventArgs e)
	{
        if (float.TryParse(systemHight.Text, out float systemHeightf))
            systemHeightf *= 10;
        if (float.TryParse(middleSideWidth.Text, out float middleSideWidthf))
            middleSideWidthf *= 10;
        if (float.TryParse(leftSideWidth.Text, out float leftSideWidthf))
            leftSideWidthf *= 10;
        if (float.TryParse(rightSideWidth.Text, out float rightSideWidthf))
            rightSideWidthf *= 10;
        
        if (string.IsNullOrWhiteSpace(leftSideWidth.Text) ^ string.IsNullOrWhiteSpace(rightSideWidth.Text))
        {
            float sideWidth = string.IsNullOrWhiteSpace(leftSideWidth.Text) ? rightSideWidthf : leftSideWidthf;
            sideWidth = string.IsNullOrWhiteSpace(rightSideWidth.Text) ? leftSideWidthf : rightSideWidthf;

            int sidePiece = 1;

            if (!string.IsNullOrWhiteSpace(leftGlassPiece.Text) && string.IsNullOrWhiteSpace(rightGlassPiece.Text))
            {
                if (int.TryParse(leftGlassPiece.Text, out int result))
                    sidePiece = result;
            }
            else if (!string.IsNullOrWhiteSpace(rightGlassPiece.Text) && string.IsNullOrEmpty(leftGlassPiece.Text))
            {
                if (int.TryParse(rightGlassPiece.Text, out int result))
                    sidePiece = result;
            }
            else
            {
                sidePiece = DeterminePiece(sideWidth);
            }

            LBalconyCalculation(systemHeightf,middleSideWidthf,sideWidth,sidePiece,glassSize);
        }
        else if (!string.IsNullOrWhiteSpace(leftSideWidth.Text) && !string.IsNullOrWhiteSpace(rightSideWidth.Text))
        {
            if (!int.TryParse(rightGlassPiece.Text, out int rightGlassPieceI))
                rightGlassPieceI = DeterminePiece(rightSideWidthf);
            if (!int.TryParse(leftGlassPiece.Text, out int leftGlassPieceI))
                leftGlassPieceI = DeterminePiece(leftSideWidthf);

            UBalconyCalculation(systemHeightf,middleSideWidthf,leftSideWidthf,leftGlassPieceI,rightSideWidthf,rightGlassPieceI,glassSize);
        }
        else
        {
            FlatBalconyCalcualtion(systemHeightf,middleSideWidthf,glassSize);
        }
    }

    public void UBalconyCalculation(float systemHeightf, float middleSideWidthf, float leftSideWidthf, int leftSidePiece, float rightSideWidthf, int rightSidePiece, Label glassSize)
    {
        var (leftSideGlassWidth, leftGlassPiece) = SideBalcony(leftSideWidthf, leftSidePiece);
        var (rightSideGlassWidth, rightGlassPiece) = SideBalcony(rightSideWidthf, rightSidePiece);
        float glassHeight = (systemHeightf - Constants.HIGHT_OFFSET);

        FlatBalconyCalcualtion(systemHeightf, middleSideWidthf, glassSize);
        glassSize.Text +=
            $"\n{leftGlassPiece} adet {glassHeight}mm x {(int)leftSideGlassWidth}mm" +
            $"\n{rightGlassPiece} adet {glassHeight}mm x {(int)rightSideGlassWidth}mm";
    }

    public void FlatBalconyCalcualtion(float systemHeightf, float middleSideWidthf, Label glassSize)
    {
        int piece = string.IsNullOrWhiteSpace(middleGlassPiece.Text) ? DeterminePiece(middleSideWidthf) : Convert.ToInt16(middleGlassPiece.Text);
        float glassWitdh = ((middleSideWidthf - Constants.WIDTH_OFFSET) - ((piece - 1) * Constants.SEPERATION)) / piece;
        float glassHeight = (systemHeightf - Constants.HIGHT_OFFSET);

        glassSize.Text = $"Cam Ölçüsü:\n{piece} adet {glassHeight}mm x {(int)glassWitdh}mm";
    }

    public void LBalconyCalculation(float systemHeightf, float middleSideWidthf, float sideWidthf, int sidePiece, Label glassSize)
    {
        var (sideGlassWidth, sideGlassPiece) = SideBalcony(sideWidthf, sidePiece);
        float glassHeight = (systemHeightf - Constants.HIGHT_OFFSET);

        FlatBalconyCalcualtion(systemHeightf, middleSideWidthf, glassSize);
        glassSize.Text += $"\n{sideGlassPiece} adet {glassHeight}mm x {(int)sideGlassWidth}mm";
    }

    public (float,int) SideBalcony(float sideWidth, int sidePiece)
    {
        return (((sideWidth - Constants.WIDTH_OFFSET_L) - ((sidePiece - 1) * Constants.SEPERATION)) / sidePiece, sidePiece);
    }

    public static int DeterminePiece(float width) => (int)(width / Constants.OPTIMUM_GLASSWIDTH) + 1;

}